using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Mikstura
    {
        public string Nazwa { get; set; }
        public int Leczenie { get; set; }

        public Mikstura(string nazwa, int leczenie)
        {
            Nazwa = nazwa;
            Leczenie = leczenie;
        }
    }
}
