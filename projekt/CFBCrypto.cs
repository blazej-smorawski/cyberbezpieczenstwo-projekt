using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    internal class CFBCrypto : Crypto
    {
        public CFBCrypto()
        {
            name = "CFBCrypto";
        }

        public override byte[] encrypt(in byte[] plainText, in byte[] key, in byte[] iv)
        {
            using (var aes = Aes.Create())
            {
                aes.Mode = CipherMode.CFB;
                aes.KeySize = 128;
                aes.BlockSize = 128;
                aes.Padding = PaddingMode.PKCS7;

                aes.Key = key;
                if(iv.Length == 0)
                {
                    aes.GenerateIV();
                }
                else
                {
                    aes.IV = iv;
                }

                byte[] encrypted;

                using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                {
                    encrypted = performCryptography(plainText, encryptor);
                }

                byte[] ciphertextwIV = aes.IV.Concat(encrypted).ToArray();

                return ciphertextwIV;
            }
        }

        public override byte[] decrypt(in byte[] encryptedText, in byte[] key, in byte[] iv)
        {
            using (var aes = Aes.Create())
            {
                aes.Mode = CipherMode.CFB;
                aes.KeySize = 128;
                aes.BlockSize = 128;
                aes.Padding = PaddingMode.PKCS7;

                byte[] IV = new byte[16];
                byte[] encryptedData = new byte[encryptedText.Length - 16];

                Array.Copy(encryptedText, IV, IV.Length);
                Array.Copy(encryptedText, 16, encryptedData, 0, encryptedData.Length);

                aes.Key = key;
                aes.IV = IV;
              

                using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                {
                    return performCryptography(encryptedData, decryptor);
                }
            }
        }
    }
}