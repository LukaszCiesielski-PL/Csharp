using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Drzwi
    {
        public static void drzwi()
        {
            string napis = Console.ReadLine().ToUpper();
            if(napis == "PROJEKT ZALICZENIOWY" || napis=="Projekt zaliczeniowy" || napis=="projekt zaliczeniowy")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\nDrzwi zaczęły się podnosić...Nie czekasz ani chwili dłużej, wbiegasz do kolejnego pomieszczenia aby zgarnąć upragniony skarb dla którego poświęciłeś tyle czasu, potu, krwi i łez...");
                Console.WriteLine("\n\tWykrzykujesz na całą salę \"W końcu mam, mam to ! Pozytywana ocena z projektu !\" A to dopiero początek !");
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else
            {
                while (napis != "PROJEKT ZALICZENIOWY" || napis != "Projekt zaliczeniowy" || napis != "projekt zaliczeniowy") ;
                {
                    napis = Console.ReadLine();
                }
            
            }
        }
        
    }
}
