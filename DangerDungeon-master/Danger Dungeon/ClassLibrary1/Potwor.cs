using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Potwor
    {
        public string Nazwa { get; set; }
        public int Obrazenia { get; set; }
        public int Wytrzymalosc { get; set; }
        public int AktualnaWytrzymalosc { get; set; }
        public int OtrzymaneDoswiadczenie { get; set; }
        public int UpuszczoneZloto { get; set; }

        public Potwor(string nazwa, int obrazenia, int wytrzymalosc, int aktualnaWyt, int otrzymDoswiadczenie, int upuszczoneZloto)
        {
            Nazwa = nazwa;
            Obrazenia = obrazenia;
            Wytrzymalosc = wytrzymalosc;
            AktualnaWytrzymalosc = aktualnaWyt;
            OtrzymaneDoswiadczenie = otrzymDoswiadczenie;
            UpuszczoneZloto = upuszczoneZloto;
        }

        
    }
}
