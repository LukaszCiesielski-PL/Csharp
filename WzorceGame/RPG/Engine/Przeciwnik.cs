using System;
using System.Collections.Generic;

namespace Engine
{
    public class Przeciwnik
    {
        public string Nazwa;
        public int Atak;
        public int Atak_Min { get; set; }
        public int Atak_Max { get; set; }
        public int Hp;
        public int Aktual_Hp;
        public int Pancerz;
        public int Aktual_Pancerz;
        public int Drop_Pieniadze;
        public int Poziom;
        public int Drop_Punkty_Doswiadczenia;
        public Przeciwnik(string nazwa="", int atak=0, int atak_min = 1, int atak_max=10, int hp=10, int aktual_hp=10, int pancerz=0, int aktual_pancerz=0, int drop_pieniadze=10, int poziom=1, int drop_punkty_doswiadczenia=10)
        {
           Nazwa = nazwa;
           Atak = atak;
           Atak_Min = atak_min;
           Atak_Max = atak_max;
           Hp = hp;
           Aktual_Hp = aktual_hp;
           Pancerz = pancerz;
           Aktual_Pancerz = aktual_pancerz;
           Drop_Pieniadze = drop_pieniadze;
           Poziom = poziom;
           Drop_Punkty_Doswiadczenia = drop_punkty_doswiadczenia;
        }


        public Przeciwnik PelnaKopia()
        {
            return (Przeciwnik) this.MemberwiseClone();                         
        }
       
        

    }


}
