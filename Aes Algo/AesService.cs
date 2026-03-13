using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Aes_Algo
{
    internal class AesService
    {
        private const int SaltSizeBytes = 16; // this will be used later for me to generate 16 bytes 
        private const int IvSizeBytes = 16;// AES block size is 16 bytes (128 bits)
        private const int Pbkdf2Iterations = 100_000; // iteration count for better security

        public EncryptionPackage Encrypt(string plaintext, string password, CipherMode mode, int keySizeBits)
        {
            if (string.IsNullOrWhiteSpace(plaintext))
                throw new ArgumentException("Plaintext is empty.");
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Key/Password is empty.");
            if (keySizeBits != 128 && keySizeBits != 192 && keySizeBits != 256)
                throw new ArgumentException("Key size must be 128, 192, or 256.");

            byte[] salt = RandomBytes(SaltSizeBytes);
            byte[] key = DeriveKey(password, salt, keySizeBits);

            byte[] iv = (mode == CipherMode.ECB) ? new byte[IvSizeBytes] : RandomBytes(IvSizeBytes);

            byte[] ciphertext; 

            using (Aes aes = Aes.Create())
            {
                aes.KeySize = keySizeBits;
                aes.Key = key;
                aes.Mode = mode;
                aes.Padding = PaddingMode.PKCS7;
                 
                if (mode != CipherMode.ECB)
                    aes.IV = iv;

                if (mode == CipherMode.CFB)
                    aes.FeedbackSize = 128;

                using (ICryptoTransform enc = aes.CreateEncryptor())
                {
                    byte[] plainBytes = Encoding.UTF8.GetBytes(plaintext);
                    ciphertext = Transform(plainBytes, enc);
                }
            }

            return new EncryptionPackage
            {
                Mode = mode.ToString(),
                KeySize = keySizeBits,
                Iterations = Pbkdf2Iterations,
                Salt = salt,
                IV = iv,
                Ciphertext = ciphertext
            };
        }

        public string Decrypt(EncryptionPackage package, string password)
        {
            if (package == null) throw new ArgumentNullException("package");
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Key/Password is empty.");

            byte[] key = DeriveKey(password, package.Salt, package.KeySize);

            using (Aes aes = Aes.Create())
            {
                aes.KeySize = package.KeySize;
                aes.Key = key;
                aes.Mode = (CipherMode)Enum.Parse(typeof(CipherMode), package.Mode);
                aes.Padding = PaddingMode.PKCS7;

                if (aes.Mode != CipherMode.ECB)
                    aes.IV = package.IV;

                if (aes.Mode == CipherMode.CFB)
                    aes.FeedbackSize = 128;

                using (ICryptoTransform dec = aes.CreateDecryptor())
                {
                    byte[] plainBytes = Transform(package.Ciphertext, dec);
                    return Encoding.UTF8.GetString(plainBytes);
                }
            }
        }

        private static byte[] DeriveKey(string password, byte[] salt, int keySizeBits)
        {
            int keySizeBytes = keySizeBits / 8;
            using (var kdf = new Rfc2898DeriveBytes(password, salt, Pbkdf2Iterations))
            {
                return kdf.GetBytes(keySizeBytes);
            }
        }

        private static byte[] RandomBytes(int count)
        {
            byte[] b = new byte[count];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(b);
            }
            return b;
        }

        private static byte[] Transform(byte[] input, ICryptoTransform transform)
        {
            using (var ms = new MemoryStream())
            {
                using (var cs = new CryptoStream(ms, transform, CryptoStreamMode.Write))
                {
                    cs.Write(input, 0, input.Length);
                    cs.FlushFinalBlock();
                }
                return ms.ToArray();
            }
        }
    }
}