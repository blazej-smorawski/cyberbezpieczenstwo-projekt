using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    internal class CBCCrypto : Crypto
    {
        public CBCCrypto()
        {
            name = "CBCCrypto";
        }

        public override byte[] encrypt(in byte[] plainText, in byte[] key, in byte[] iv)
        {
            using (var aes = Aes.Create())
            {
                aes.Mode = CipherMode.CBC;
                aes.KeySize = 128;
                aes.BlockSize = 128;
                aes.Padding = PaddingMode.PKCS7;

                aes.Key = key;
                aes.IV = iv;

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
                aes.Mode = CipherMode.CBC;
                aes.KeySize = 128;
                aes.BlockSize = 128;
                aes.Padding = PaddingMode.PKCS7;

                aes.Key = key;
                aes.IV = iv;

                using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                {
                    return performCryptography(encryptedText, decryptor);
                }
            }
        }

        private byte[] performCryptography(byte[] data, ICryptoTransform cryptoTransform)
        {
            using (var ms = new MemoryStream())
            {
                using (var cryptoStream = new CryptoStream(ms, cryptoTransform, CryptoStreamMode.Write))
                {
                    // TODO: Add handling for badly shaped data
                    cryptoStream.Write(data, 0, data.Length);
                    cryptoStream.FlushFinalBlock();

                    return ms.ToArray();
                }
            }
        }
    }
}