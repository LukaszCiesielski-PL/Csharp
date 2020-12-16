using System;

namespace TimeTimePeriod
{
    class Program
    {
        static void Main()
        {
            int x = 2;

            Time t1 = new Time("2:22:22");
            Time t2 = new Time("2:22:22");
            Time t3 = new Time("1:11:11");
            Time t4 = new Time("2:52:22");


            TimePeriod tp1 = new TimePeriod("2:22:22");
            TimePeriod tp2 = new TimePeriod("2:22:22");
            TimePeriod tp3 = new TimePeriod("1:11:11");
            TimePeriod tp4 = new TimePeriod("2:52:22");



            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Operacje dla Time \n");

            Console.WriteLine("t1 - 2:22:22 \nt2 - 2:22:22 \nt3 - 1:11:11 \nt4 - 2:52:22 \nx - 2\n");


            Console.WriteLine($"Równość:    t1 == t2 \t{t1 == t2}");
            Console.WriteLine($"Nierówność: t1 != t3 \t{t1 != t3}");
            Console.WriteLine($"Większość:  t1 > t3  \t{t1 > t3}");
            Console.WriteLine($"Mniejszość: t3 < t2  \t{t3 < t2}");
            Console.WriteLine($"M/R:        t1 <= t2 \t{t1 <= t2}");
            Console.WriteLine($"W/R:        t1 >= t2 \t{t1 >= t2}");


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\nOperacje dla TimePeriod \n");

            Console.WriteLine("tp1 - 2:22:22 \ntp2 - 2:22:22 \ntp3 - 1:11:11 \ntp4 - 2:52:22 \nx - 2\n");


            Console.WriteLine($"Równość:    tp1 == tp2 \t{tp1 == tp2}");
            Console.WriteLine($"Nierówność: tp1 != tp3 \t{tp1 != tp3}");
            Console.WriteLine($"Większość:  tp1 > tp3  \t{tp1 > tp3}");
            Console.WriteLine($"Mniejszość: tp3 < tp2  \t{tp3 < tp2}");
            Console.WriteLine($"M/R:        tp1 <= tp2 \t{tp1 <= tp2}");
            Console.WriteLine($"W/R:        tp1 >= tp2 \t{tp1 >= tp2}");
            Console.WriteLine($"Dodawanie:  tp2 + tp4  \t{tp4 + tp2}");
            Console.WriteLine($"Odejmowanie:tp4 - tp3  \t{tp4 - tp3}");
            Console.WriteLine($"Mnożenie:   tp1 * x  \t{tp1 * x}");
            Console.WriteLine($"Dzielenie:  tp1 / x  \t{tp1 / x}");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\nOperacje dla Time oraz TimePeriod \n");

            Console.WriteLine("tp1 - 2:22:22 \ntp3 - 1:11:11\n");
            Console.WriteLine("t1 - 2:22:22  \nt3 - 1:11:11\n");

            Console.WriteLine($"Dodawanie punktu w czasie do przedziału:  t3 + tp1  \t{t3 + tp3}");
            Console.WriteLine($"Odejmowanie przedziału od punktu w czasie:t3 - tp1  \t{t3 - tp1}");

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
