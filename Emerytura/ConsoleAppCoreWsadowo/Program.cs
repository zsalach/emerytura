/**
 * Aplikacja w .NET Core
 * Aplikacja działa w trybie wsadowym wykorzystuje parametry przekazane w linii comend
 * przykład urzycia w app.exe imię nazwisko wiek
 */


using System;

namespace ConsoleAppCoreWsadowo
{
    class Program
    {
        const int wiekEmerytalny = 67;

        static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("Za mało parametrów. ");
                return;
            }

            string imie = args[0];
            string nazwisko = args[1];
            int wiek = int.Parse(args[2]); //Parsujemy 

           
                Console.WriteLine($"Witaj {imie} {nazwisko}!");
                Console.WriteLine($"Masz {wiek} lat.");

                if (wiek > wiekEmerytalny)
                {
                    Console.WriteLine("Gratuluję, jesteś juś emerytem");
                }
                Console.WriteLine($"Zostało ci jeszcze {wiekEmerytalny - wiek} do emerytury");
           
                if (args.Length == 2)
                {
                    Console.WriteLine($"Witaj {imie} {nazwisko}!");
                }
        }
    }
}
