using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{

    class Poruszanie
    {

        public static void RuchNPL()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nN - idź do przodu");
            Console.WriteLine("L - Skręć w lewo");
            Console.WriteLine("P - Skręć w prawo");
            Console.Write("W którą stronę pójdziesz: ");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void RuchNP()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nN - idź do przodu");
            Console.WriteLine("P - Skręć w prawo");
            Console.Write("W którą stronę pójdziesz: ");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void RuchNL()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nN - idź do przodu");
            Console.WriteLine("L - Skręć w lewo");
            Console.Write("W którą stronę pójdziesz: ");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void RuchPL()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nP - Skręć w prawo");
            Console.WriteLine("L - Skręć w lewo");
            Console.Write("W którą stronę pójdziesz: ");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void RuchN()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nN - idź do przodu");
            Console.Write("W którą stronę pójdziesz: ");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void Nagroda()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n1 - wybieram +3 do obrażen - 200złota");
            Console.WriteLine("2 - wybieram +10 do wytrzymałości - 200złota");
            Console.WriteLine("3 - wybieram obie statystyki i tajemniczy efekt");
            Console.Write("Co robisz: ");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
