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

        abstract public byte[] encrypt(in byte[] plainText);
        abstract public byte[] decrypt(in byte[] plainText);
    }
}
