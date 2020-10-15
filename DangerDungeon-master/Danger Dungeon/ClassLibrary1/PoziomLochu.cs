using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class PoziomLochu
    {
        
        public string NazwaPoziomu { get; set; }
        public string Historia { get; set; }
        
        public PoziomLochu(string nazwaPzm=null, string historia=null)
        {
            
            NazwaPoziomu = nazwaPzm;
            Historia = historia;
            

        }
    }
}
