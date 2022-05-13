using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace projekt
{
    internal abstract class Crypto
    {
        public string name = "Crypto";

        abstract public byte[] encrypt(in byte[] plainText, in byte[] key, in byte[] iv);
        abstract public byte[] decrypt(in byte[] plainText, in byte[] key, in byte[] iv);

        protected byte[] performCryptography(byte[] data, ICryptoTransform cryptoTransform)
        {
            using (var ms = new MemoryStream())
            {
                using (var cryptoStream = new CryptoStream(ms, cryptoTransform, CryptoStreamMode.Write))
                {
                    try
                    {
                        cryptoStream.Write(data, 0, data.Length);
                        cryptoStream.FlushFinalBlock();
                    }
                    catch (System.Security.Cryptography.CryptographicException e)
                    {
                        MessageBox.Show(e.Message, "Error");
                    }

                    return ms.ToArray();
                }
            }
        }
    }
}
