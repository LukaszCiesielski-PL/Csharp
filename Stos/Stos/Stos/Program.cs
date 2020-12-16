using System;

namespace Stos
{
    class Program
    {
        static void Main(string[] args)
        {
            StosWTablicy<string> s = new StosWTablicy<string>();
            s.Push("km");
            s.Push("aa");
            s.Push("ab");
           

            foreach (var x in s.ToArray())
                Console.WriteLine(x);

            
            foreach (var x in ((StosWTablicy<string>)s).Order)
                Console.WriteLine(x);

            Console.WriteLine($"Actual: {s.GetActualTabLength()}");
            s.TrimExcess();

            Console.WriteLine($"Length: {s.GetActualTabLength()}");

            Console.WriteLine($"First text: {s[0]} {"km" == s[0]}");

            Console.WriteLine($"Last text: {s[2]} {"ab" == s[2]}");


        }
    }
}
