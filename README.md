AES Encryption and Decryption System (WinForms GUI)


This project is a Windows Forms (WinForms) desktop application that allows users to encrypt and decrypt text using the AES (Advanced Encryption Standard) algorithm.

The application provides a graphical user interface where users can:

Enter plaintext to encrypt

Enter a secret key (password)

Select an AES mode of operation

Select AES key length

Encrypt the plaintext

Save the encrypted data to a .txt file

Load encrypted data from a .txt file

Decrypt the ciphertext back to the original plaintext

The system uses the built-in .NET cryptography library to implement AES securely.


**Features**

The application supports the following features:

**Encryption**

User enters plaintext

User provides a password

User selects AES mode (ECB, CBC, CFB)

User selects key length (128 / 192 / 256 bits)

The program encrypts the message using AES

The ciphertext is displayed and can be saved to a .txt file


**Decryption**

User loads a .txt file containing encrypted data

User enters the same password used during encryption

The program decrypts the ciphertext

The original plaintext message is displayed



**File Storage**

Encrypted messages are saved to a .txt file containing:

AES mode

Key size

PBKDF2 iteration count

Salt

Initialization Vector (IV)

Ciphertext

This ensures the encrypted message can be correctly decrypted later.
