using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    internal class ECBCrypto : Crypto
    {
        public ECBCrypto()
        {
            name = "ECBCrypto";
        }

        public override byte[] encrypt(in byte[] plainText, in byte[] key, in byte[] iv)
        {
            using (var aes = Aes.Create())
            {
                aes.Mode = CipherMode.ECB;
                aes.KeySize = 128;
                aes.BlockSize = 128;
                aes.Padding = PaddingMode.PKCS7;

                aes.Key = key;

                using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                {
                    return performCryptography(plainText, encryptor);
                }
            }
        }

        public override byte[] decrypt(in byte[] encryptedText, in byte[] key, in byte[] iv)
        {
            using (var aes = Aes.Create())
            {
                aes.Mode = CipherMode.ECB;
                aes.KeySize = 128;
                aes.BlockSize = 128;
                aes.Padding = PaddingMode.PKCS7;

                aes.Key = key;
              
                using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                {
                    return performCryptography(encryptedText, decryptor);
                }
            }
        }
    }
}