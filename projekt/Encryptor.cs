using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    internal interface Encryptor
    {
        public byte[] encrypt(in byte[] plainText);
    }
}
