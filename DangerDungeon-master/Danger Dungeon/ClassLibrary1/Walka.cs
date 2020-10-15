using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
namespace ClassLibrary1
{
    public class Walka
    {
       
        public static void walkaDziedziniec(Postac postac, Potwor potwor)
        {

            Random cios = new Random();

            int Cios = cios.Next(potwor.Obrazenia, potwor.Obrazenia + 1);
            postac.AktualnaWytrzymalosc = postac.AktualnaWytrzymalosc - Cios;
            Console.WriteLine($"\n\t{potwor.Nazwa} uderzył za: {Cios} HP. Zostało Ci {postac.AktualnaWytrzymalosc}");

            do
            {
               
                Akcja();
                string akcja = Console.ReadLine().ToUpper();
                switch (akcja)
                {
                    case "A":
                        int Cioss = cios.Next(postac.Obrazenia - 5, postac.Obrazenia + 5);
                        potwor.AktualnaWytrzymalosc = potwor.AktualnaWytrzymalosc - Cioss;
                        Console.WriteLine($"\n\tUderzyłeś za: {Cioss} PKT. {potwor.Nazwa}owi zostało: {potwor.AktualnaWytrzymalosc} HP");
                        if (potwor.AktualnaWytrzymalosc <= 0) continue;
                        int Cioos = cios.Next(potwor.Obrazenia-5, potwor.Obrazenia + 5);
                        postac.AktualnaWytrzymalosc = postac.AktualnaWytrzymalosc - Cioos;
                        Console.WriteLine($"\n\t{potwor.Nazwa} uderzył za: {Cioos} PKT. Zostało Ci {postac.AktualnaWytrzymalosc} HP");
                        break;

                    case "B":
                        Cios = cios.Next(potwor.Obrazenia-5, potwor.Obrazenia);
 
                        postac.AktualnaWytrzymalosc = postac.AktualnaWytrzymalosc - Cios;
                        Console.WriteLine($"\n\t{potwor.Nazwa} uderzył za: {Cios} PKT. Zostało Ci {postac.AktualnaWytrzymalosc} HP");
                        break;

                    case "C":
                        postac.AktualnaWytrzymalosc = postac.AktualnaWytrzymalosc + 24;
                        if(postac.AktualnaWytrzymalosc > postac.Wytrzymalosc) { postac.AktualnaWytrzymalosc = postac.Wytrzymalosc; }
                        Console.WriteLine($"\n\tTwoje życie: {postac.AktualnaWytrzymalosc}");
                        Cioos = cios.Next(potwor.Obrazenia-7, potwor.Obrazenia + 8);
                        postac.AktualnaWytrzymalosc = postac.AktualnaWytrzymalosc - Cioos;
                        Console.WriteLine($"\n\t{potwor.Nazwa} uderzył za: {Cioos} PKT. Zostało Ci {postac.AktualnaWytrzymalosc} HP");
                        break;

                }
                if (postac.AktualnaWytrzymalosc <= 0)
                {
                    Console.WriteLine("\nZostałeś zabity, Twoje truchło zostanie tu na wieki!");
                    Process.GetCurrentProcess().Kill();
                }

            } while (postac.AktualnaWytrzymalosc > 0 && potwor.AktualnaWytrzymalosc > 0);
            

            Console.WriteLine(postac.AktualnaWytrzymalosc > potwor.AktualnaWytrzymalosc ? $"\n\tWygrałeś! Otrzymujesz: {postac.PunktyDoswiadczenia = 100} Expa" : "\n\tPrzegrałeś");
   
            
           if(postac.PunktyDoswiadczenia >= 100 || postac.PunktyDoswiadczenia >= 300 || postac.PunktyDoswiadczenia >= 500 || postac.PunktyDoswiadczenia >= 1000)
            {
                postac.Poziom++;
                postac.Obrazenia = postac.Obrazenia + 5;
                postac.Wytrzymalosc = postac.Wytrzymalosc + 10;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\tTwój poziom i statystyki wzrosły: {postac.Poziom} lvl");
                Console.ForegroundColor = ConsoleColor.White;
            }
            
        }


        public static void Akcja()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nA - atak");
            Console.WriteLine("B - blok");
            Console.WriteLine("C - ulecz się o 20 HP");
            Console.Write("Co robisz: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        
    }
}

