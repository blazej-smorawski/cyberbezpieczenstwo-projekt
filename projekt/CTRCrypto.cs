using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    internal class CTRCrypto : Crypto
    {
        public CTRCrypto()
        {
            name = "CTRCrypto";
        }

        public override byte[] encrypt(in byte[] plainText, in byte[] key, in byte[] iv)
        {
            if(iv.Length != 16)
            {
                throw new System.Security.Cryptography.CryptographicException("Wrong size of the iv");
            }

            byte[] plainTextCopy = new byte[plainText.Length];
            Array.Copy(plainTextCopy, plainText, plainText.Length);
            int size = ((plainText.Length + 15) / 16) * 16;
            Array.Resize(ref plainTextCopy, size);
            byte[] cipherText = new byte[size];

            for (int i = 0; i < size; i+=16)
            {
                byte[] encrypted;
                using (var aes = Aes.Create())
                {
                    aes.Mode = CipherMode.ECB;
                    aes.KeySize = 128;
                    aes.BlockSize = 128;
                    aes.Padding = PaddingMode.PKCS7;

                    aes.Key = key;

                    using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                    {
                        encrypted = performCryptography(iv, encryptor);
                    }
                }
               
                for(int j = 0; j < encrypted.Length; j++)
                {
                    cipherText[i+j] = (byte)((int)encrypted[j] ^ (int)plainTextCopy[i+j]);
                }

                for (int j = 0; j < iv.Length; j++)
                {
                    if ((int)iv[j] < 255)
                    {
                        iv[j] = (byte)((int)iv[j] + 1);
                        break;
                    }
                }
            }
            return cipherText;
        }

        public override byte[] decrypt(in byte[] encryptedText, in byte[] key, in byte[] iv)
        {

            if (iv.Length != 16)
            {
                throw new System.Security.Cryptography.CryptographicException("Wrong size of the iv");
            }

            byte[] encryptedTextCopy = new byte[encryptedText.Length];
            Array.Copy(encryptedTextCopy, encryptedText, encryptedText.Length);
            int size = ((encryptedText.Length + 15) / 16) * 16;
            Array.Resize(ref encryptedTextCopy, size);
            byte[] plainText = new byte[size];

            for (int i = 0; i < size; i += 16)
            {
                byte[] encrypted;
                using (var aes = Aes.Create())
                {
                    aes.Mode = CipherMode.ECB;
                    aes.KeySize = 128;
                    aes.BlockSize = 128;
                    aes.Padding = PaddingMode.PKCS7;

                    aes.Key = key;

                    using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                    {
                        encrypted = performCryptography(iv, encryptor);
                    }
                }

                for (int j = 0; j < encrypted.Length; j++)
                {
                    plainText[i + j] = (byte)((int)encrypted[j] ^ (int)encryptedTextCopy[i + j]);
                }

                for (int j = 0; j < iv.Length; j++)
                {
                    if ((int)iv[j] < 255)
                    {
                        iv[j] = (byte)((int)iv[j] + 1);
                        break;
                    }
                }
            }
            return plainText;
        }
    }
}