using System;
using System.IO;

namespace Aes_Algo
{
    internal static class PackageFormat
    {
       

        public static void SaveToFile(string filePath, EncryptionPackage package)
        {
            if (package == null) throw new ArgumentNullException("package");

            string[] lines = new string[]
            {
                "AES_PACKAGE_V1",
                "mode=" + package.Mode,
                "keySize=" + package.KeySize,
                "iterations=" + package.Iterations,
                "salt=" + Convert.ToBase64String(package.Salt ?? new byte[0]),
                "iv=" + Convert.ToBase64String(package.IV ?? new byte[0]),
                "ciphertext=" + Convert.ToBase64String(package.Ciphertext ?? new byte[0]),
            };

            File.WriteAllLines(filePath, lines);
        }

        public static EncryptionPackage LoadFromFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            if (lines.Length < 7 || lines[0] != "AES_PACKAGE_V1")
                throw new InvalidDataException("Invalid file format.");

            EncryptionPackage p = new EncryptionPackage();

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];
                int eq = line.IndexOf('=');
                if (eq <= 0) continue;

                string key = line.Substring(0, eq).Trim();
                string value = line.Substring(eq + 1).Trim();

                if (key == "mode") p.Mode = value;
                else if (key == "keySize") p.KeySize = int.Parse(value);
                else if (key == "iterations") p.Iterations = int.Parse(value);
                else if (key == "salt") p.Salt = Convert.FromBase64String(value);
                else if (key == "iv") p.IV = Convert.FromBase64String(value);
                else if (key == "ciphertext") p.Ciphertext = Convert.FromBase64String(value);
            }

            if (string.IsNullOrWhiteSpace(p.Mode) || p.KeySize == 0 || p.Ciphertext == null)
                throw new InvalidDataException("Missing fields in file.");

            return p;
        }
    }
}