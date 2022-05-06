using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    internal class TestCrypto : Crypto
    {
        public TestCrypto()
        {
            name = "Test Crypto";
        }

        override public byte[] encrypt(in byte[] plainText, in byte[] key, in byte[] iv)
        {
            byte[] encryptedText = new byte[plainText.Length];
            for (int i = 0; i < encryptedText.Length; i++)
            {
                encryptedText[i] = (byte)(plainText[i] + 1);
            }
            return encryptedText;
        }

        override public byte[] decrypt(in byte[] plainText, in byte[] key, in byte[] iv)
        {
            byte[] encryptedText = new byte[plainText.Length];
            for (int i = 0; i < encryptedText.Length; i++)
            {
                encryptedText[i] = (byte)(plainText[i] - 1);
            }
            return encryptedText;
        }
    }
}
