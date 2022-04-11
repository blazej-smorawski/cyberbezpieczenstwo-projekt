using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    internal class TestEncryptor : Encryptor
    {
        public byte[] encrypt(in byte[] plainText)
        {
            byte[] encryptedText = new byte[plainText.Length];
            for (int i = 0; i < encryptedText.Length; i++)
            {
                encryptedText[i] = (byte)(plainText[i] + 1);
            }
            return encryptedText;
        }
}
}
