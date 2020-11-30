using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Zagadka
    {
        public int Numer { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public int OtrzymaneDoswiadczenie { get; set; }
        public int UpuszczoneZloto { get; set; }

        public Zagadka(int numer, string nazwa, string opis, int otrzymaneDos, int upuszczoneZloto)
        {
            Numer = numer;
            Nazwa = nazwa;
            Opis = opis;
            OtrzymaneDoswiadczenie = otrzymaneDos;
            UpuszczoneZloto = upuszczoneZloto;
        }
    }
}
