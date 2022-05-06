using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    internal abstract class Crypto
    {
        public string name = "Crypto";

        abstract public byte[] encrypt(in byte[] plainText, in byte[] key);
        abstract public byte[] decrypt(in byte[] plainText, in byte[] key);
    }
}
