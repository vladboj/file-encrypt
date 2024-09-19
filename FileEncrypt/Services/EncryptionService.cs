using System.Security.Cryptography;
using System.Text;

namespace FileEncrypt.Services
{
    internal static class EncryptionService
    {
        private static byte[] EncryptStringToBytes_Aes(string plainText, byte[] key, byte[] iv)
        {
            // Declare bytes array used to hold the encrypted text.
            byte[] cipherText;

            // Create an aes object with the specified key.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                // Create an encryptor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            // Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }

                        cipherText = msEncrypt.ToArray();
                    }
                }
            }

            return cipherText;
        }

        public static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] key, byte[] iv)
        {
            // Declare the string used to hold the decrypted text.
            string plainText;

            // Create an aes object with the specified key.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.IV = iv;

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            // Read the decrypted bytes from the decrypting stream and place them in a string.
                            plainText = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }

            return plainText;
        }

        private static byte[] GenerateKey(string password, byte[] salt)
        {
            // Convert password to byte array.
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);

            // Generate the key.
            byte[] key = Rfc2898DeriveBytes.Pbkdf2(passwordBytes, salt, 10000, HashAlgorithmName.SHA256, 32);

            return key;
        }

        public static byte[] EncryptFile(string filePath, string password)
        {
            // Read text from the given file.
            string plainText = File.ReadAllText(filePath, Encoding.UTF8);

            // Generate salt used for deriving a key from the password.
            byte[] salt = new byte[16];
            RandomNumberGenerator.Fill(salt);

            // Generate the encryption key based on the given password.
            byte[] key = GenerateKey(password, salt);

            byte[] combinedData;

            using (Aes myAes = Aes.Create())
            {
                // Encrypt the plain text.
                byte[] cipherText = EncryptStringToBytes_Aes(plainText, key, myAes.IV);

                // Concatenate salt, IV, and cipher text into a single byte array.
                combinedData = new byte[salt.Length + myAes.IV.Length + cipherText.Length];
                Buffer.BlockCopy(salt, 0, combinedData, 0, salt.Length);
                Buffer.BlockCopy(myAes.IV, 0, combinedData, salt.Length, myAes.IV.Length);
                Buffer.BlockCopy(cipherText, 0, combinedData, salt.Length + myAes.IV.Length, cipherText.Length);
            }

            return combinedData;
        }

        public static string DecryptFile(string filePath, string password)
        {
            // Read bytes from the given file.
            byte[] combinedData = File.ReadAllBytes(filePath);

            // Extract salt, IV and cipher text from combined data.
            byte[] salt = new byte[16];
            byte[] iv = new byte[16];
            byte[] cipherText = new byte[combinedData.Length - salt.Length - iv.Length];
            Array.Copy(combinedData, salt, salt.Length);
            Array.Copy(combinedData, salt.Length, iv, 0, iv.Length);
            Array.Copy(combinedData, salt.Length + iv.Length, cipherText, 0, cipherText.Length);

            // Generate the encryption key.
            byte[] key = GenerateKey(password, salt);

            // Decrypt the cipher text.
            string plainText = DecryptStringFromBytes_Aes(cipherText, key, iv);

            return plainText;
        }
    }
}