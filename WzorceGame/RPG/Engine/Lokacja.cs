using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Lokacja
    {
        public int ID { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public Przeciwnik PrzeciwnikWLokacji { get; set; }
        public Zadanie ZadanieWLokacji { get; set; }
        public Lokacja LokacjaDalej { get; set; }

        public Lokacja(int id, string nazwa, string opis, Przeciwnik przeciwnikwlokacji = null, Zadanie zadaniewlokcaji = null)
        {
            ID = id;
            Nazwa = nazwa;
            Opis = opis;
            PrzeciwnikWLokacji = przeciwnikwlokacji;
            ZadanieWLokacji = zadaniewlokcaji;

        }
    }
}
