using System;
using System.Collections.Generic;
using System.Threading;
using Engine;
using Microsoft.Azure.Amqp;
using System.Security.Cryptography;

namespace RPG
{

    class Program
    {
        static void Main(string[] args)
        {
            PostacGracza postacGracza = PostacGracza.GetInstance();


            Przeciwnik przeciwnikGracza = new Przeciwnik();
            przeciwnikGracza.Nazwa = "Szczur";
            Console.WriteLine($"Twoim przeciwnikiem jest {przeciwnikGracza.Nazwa}");
            Walka.Bitwa(postacGracza, przeciwnikGracza);

            Console.ForegroundColor = ConsoleColor.Yellow;
            bool czyUleczyc = Leczenie.CzyUleczyc(postacGracza);
            Console.WriteLine("Czy uleczyć gracza o 20 HP ? " + (czyUleczyc ? "TAK" : "NIE, moje życie nie spadło poniżej połowy"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Twoje zdrowie wynosi teraz: {postacGracza.Aktual_Hp}");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Idziesz dalej...\n");
            Console.ForegroundColor = ConsoleColor.White;

            Przeciwnik przeciwnikGracza2 = przeciwnikGracza.PelnaKopia();
            przeciwnikGracza.Nazwa = "Szkielet";
            Console.WriteLine($"Twoim przeciwnikiem jest {przeciwnikGracza.Nazwa}");
            przeciwnikGracza2.Aktual_Hp = 30;
            przeciwnikGracza2.Atak_Max = 20;
            Walka.Bitwa(postacGracza, przeciwnikGracza2);

            Console.ForegroundColor = ConsoleColor.Yellow;
            bool czyUleczyc2 = Leczenie.CzyUleczyc(postacGracza);
            Console.WriteLine("Czy uleczyć gracza o 20 HP ? " + (czyUleczyc2 ? "TAK" : "NIE, moje życie nie spadło poniżej połowy"));
            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Twoje zdrowie wynosi teraz: {postacGracza.Aktual_Hp}");
            Console.ForegroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Idziesz dalej...\n");
            Console.ForegroundColor = ConsoleColor.White;

            
        }
    }
}
