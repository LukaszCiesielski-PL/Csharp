using System;
using System.Collections.Generic;

namespace Engine
{
    public class PostacGracza
    {
        public string Nazwa { get; set; }
        public int Atak { get; set; }
        public int Atak_Min { get; set; }
        public int Atak_Max { get; set; }
        public int Hp { get; set; }
        public int Aktual_Hp { get; set; }
        public int Pancerz { get; set; }
        public int Aktual_Pancerz { get; set; }
        public int Pieniadze { get; set; }
        public int Poziom 
        {
            get
            {
                return ((Punkty_Doswiadczenia / 100) + 1);
            }
        }
        
        public int Punkty_Doswiadczenia { get; private set; }
        public PostacGracza() 
        {
           
        }

        private static PostacGracza _instance;
        private static readonly object _lock = new PostacGracza();

        public static PostacGracza GetInstance(string nazwa = "", int atak=0, int atak_min=1, int atak_max = 10, int hp = 100, int aktual_hp = 100, int pancerz = 0, int aktual_pancerz = 0, int pieniadze = 0, int poziom = 1, int punkty_doswiadczenia = 0)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new PostacGracza
                        {
                            Nazwa = nazwa,
                            Atak = atak,
                            Atak_Min = atak_min,
                            Atak_Max = atak_max,
                            Hp = hp,
                            Aktual_Hp = aktual_hp,
                            Pancerz = pancerz,
                            Aktual_Pancerz = aktual_pancerz,
                            Pieniadze = pieniadze,
                            Punkty_Doswiadczenia = punkty_doswiadczenia
                        };
                    }
                }
            }
            return _instance;
        }
        
    }

    
}
