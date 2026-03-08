using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aes_Algo
{
    [Serializable]
    public class EncryptionPackage
    {
        public string Mode { get; set; }        
        public int KeySize { get; set; }        
        public int Iterations { get; set; }    
        public byte[] Salt { get; set; }        
        public byte[] IV { get; set; }          
        public byte[] Ciphertext { get; set; }  
    }
}
