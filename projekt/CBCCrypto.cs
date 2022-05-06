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
        public string name;

        public CBCCrypto()
        {
            name = "CBCCrypto";
        }

        public override byte[] encrypt(in byte[] plainText, in byte[] key)
        {

            using (var aes = Aes.Create())
            {
                aes.Mode = CipherMode.CBC;
                aes.KeySize = 128;
                aes.BlockSize = 128;
                aes.Padding = PaddingMode.PKCS7;
                //PasswordDeriveBytes password = new PasswordDeriveBytes(key, null);
                //byte[] keyBytes = password.GetBytes(key.Length / 8);

                aes.Key = key;
                aes.GenerateIV();

                byte[] encrypted;
                using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                {
                    encrypted = PerformCryptography(plainText, encryptor);
                }

                byte[] connected = aes.IV.Concat(encrypted).ToArray();

                return connected;
            }
        }

        public override byte[] decrypt(in byte[] encryptedText, in byte[] key)
        {
            using (var aes = Aes.Create())
            {
                aes.Mode = CipherMode.CBC;
                aes.KeySize = 128;
                aes.BlockSize = 128;
                aes.Padding = PaddingMode.PKCS7;

                // read IV from encryptedText
                byte[] IV = new byte[16];
                byte[] encrypted_data = new byte[encryptedText.Length - 16];

                Array.Copy(encryptedText, IV, IV.Length);
                Array.Copy(encryptedText, 16, encrypted_data, 0, encrypted_data.Length);

                aes.Key = key;
                aes.IV = IV;

                using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                {
                    return PerformCryptography(encrypted_data, decryptor);
                }
            }
        }

        private byte[] PerformCryptography(byte[] data, ICryptoTransform cryptoTransform)
        {
            using (var ms = new MemoryStream())
            using (var cryptoStream = new CryptoStream(ms, cryptoTransform, CryptoStreamMode.Write))
            {
                cryptoStream.Write(data, 0, data.Length);
                // no need for that (using)
                cryptoStream.FlushFinalBlock();

                return ms.ToArray();
            }
        }
    }
}