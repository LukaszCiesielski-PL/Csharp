using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Klucz
    {
        public string Czesc { get; set; }
        public string Rodzaj { get; set; }
        
        public Klucz(string czesc, string rodzaj)
        {
            Czesc = czesc;
            Rodzaj = rodzaj;
        }

        public override string ToString() => $"{Czesc} -> {Rodzaj}";
    }
    
}
