using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Diagnostics;

namespace Engine
{
    public class Walka
    {
        
        public static bool KtoZaczynaWalke()
        {
            int rzut;
            int rzut2;
            do 
            {
                Console.WriteLine("Przed walką rzuć kością aby zobaczyć kto zaczyna jako pierwszy.");
                Console.WriteLine("\nTwój rzut");
                Random ZaczynaGracz = new Random();
                rzut = ZaczynaGracz.Next(1, 6);
                Console.WriteLine($"Wyrzuciłeś: {rzut} \n\nTeraz kolej przeciwnika...");
                Random ZaczynaPrzeciwnik = new Random();
                rzut2 = ZaczynaPrzeciwnik.Next(1, 6);
                Console.WriteLine($"Przeciwnik wyrzucił: {rzut2}");
                if(rzut == rzut2)
                {
                    Console.WriteLine("\nRemis, rzucacie jeszcze raz.\n");
                    Console.WriteLine("Twój rzut");                   
                    rzut = ZaczynaGracz.Next(1, 6);
                    Console.WriteLine($"Wyrzuciłeś: {rzut} \n\nTeraz kolej przeciwnika...");                    
                    rzut2 = ZaczynaPrzeciwnik.Next(1, 6);
                    Console.WriteLine($"Przeciwnik wyrzucił: {rzut2}");
                }
                if (rzut > rzut2)
                {

                    return true;
                }
                else
                {

                    return false;
                }
            } while ( rzut==rzut2 );

            
        }
        
        public static void Bitwa(PostacGracza postac, Przeciwnik przeciwnik)
        {
            
            if (KtoZaczynaWalke())
            {
                Console.WriteLine("\nZaczyna gracz");
                do
                {
                    postac.Atak = LosowanieLiczb.GeneratorLiczbPseudolosowych.LiczbaPomiedzy(postac.Atak_Min, postac.Atak_Max);
                    przeciwnik.Aktual_Hp = przeciwnik.Aktual_Hp - postac.Atak;
                    Console.WriteLine($"Uderzyłeś za {postac.Atak}, przeciwnikowi zostało {Math.Max(przeciwnik.Aktual_Hp,0)} HP");
                    if (przeciwnik.Aktual_Hp > 0)
                    {
                        przeciwnik.Atak = LosowanieLiczb.GeneratorLiczbPseudolosowych.LiczbaPomiedzy(przeciwnik.Atak_Min, przeciwnik.Atak_Max);
                        postac.Aktual_Hp = postac.Aktual_Hp - przeciwnik.Atak;
                        Console.WriteLine($"Dostałeś za {przeciwnik.Atak}, zostało Ci {postac.Aktual_Hp} HP");

                        if (postac.Aktual_Hp <= 0)
                        {
                            Console.WriteLine("Zginąłeś !");
                            Process.GetCurrentProcess().Kill();
                        }
                        
                    }
                     
                } while (przeciwnik.Aktual_Hp > 0 && postac.Aktual_Hp > 0);  
                Console.WriteLine("Przeciwnik zginął, wygrałeś !\n\n");
               
            }
            else
            {
                Console.WriteLine("\nZaczyna przeciwnik");
                do
                {
                    przeciwnik.Atak = LosowanieLiczb.GeneratorLiczbPseudolosowych.LiczbaPomiedzy(przeciwnik.Atak_Min, przeciwnik.Atak_Max);
                    postac.Aktual_Hp = postac.Aktual_Hp - przeciwnik.Atak;
                    Console.WriteLine($"Dostałeś za {przeciwnik.Atak}, zostało Ci {postac.Aktual_Hp} HP");
                    if (postac.Aktual_Hp > 0)
                    {
                        postac.Atak = LosowanieLiczb.GeneratorLiczbPseudolosowych.LiczbaPomiedzy(postac.Atak_Min, postac.Atak_Max);
                        przeciwnik.Aktual_Hp = przeciwnik.Aktual_Hp - postac.Atak;
                        Console.WriteLine($"Uderzyłeś za {postac.Atak}, przeciwnikowi zostało {Math.Max(przeciwnik.Aktual_Hp,0)} HP");

                        if (przeciwnik.Aktual_Hp <= 0)
                        {
                            Console.WriteLine("Przeciwnik zginął, wygrałeś !\n\n");
                            
                        }                                            
                    }
                    if (postac.Aktual_Hp <= 0)
                    {
                        Console.WriteLine("Zginąłeś !");
                        Process.GetCurrentProcess().Kill();
                    }
                } while (przeciwnik.Aktual_Hp > 0 && postac.Aktual_Hp > 0);
                
            }


        }

    }
   
}
