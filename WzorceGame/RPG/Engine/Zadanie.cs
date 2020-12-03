using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class Zadanie
    {
        public int ID { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public int PunktyDoswiadczeniaDoZdobycia { get; set; }
        public int ZlotoDoZdobycia { get; set; }

        public Zadanie(string nazwa, string opis, int punktyDoswiadczeniaDoZdobycia, int zlotoDoZdobycia)
        {
            
            Nazwa = nazwa;
            Opis = opis;
            PunktyDoswiadczeniaDoZdobycia = punktyDoswiadczeniaDoZdobycia;
            ZlotoDoZdobycia = zlotoDoZdobycia;
            
        }
        public Zadanie PelnaKopiaZadania()
        {
            return (Zadanie)this.MemberwiseClone();
        }
    }
   
}
