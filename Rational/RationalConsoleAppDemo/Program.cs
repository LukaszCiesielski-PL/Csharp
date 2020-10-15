using System;
using RationalLib;
namespace RationalConsoleAppDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Rational32.HALF);
            Rational32 u = new Rational32(1, 2);
            var w = new Rational32(0, 0);
            var z = new Rational32();
            Rational32 x = u;

            Console.WriteLine(u);
            Console.WriteLine(w);
            Console.WriteLine(z);
            Console.WriteLine(x);
        }
    }
}
