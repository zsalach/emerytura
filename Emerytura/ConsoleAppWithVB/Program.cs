using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic; // podajemy przestreń nazw do VisualBasica

namespace ConsoleAppWithVB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;  // domyślne kopdowanie danych wejściowych'
            Console.OutputEncoding = Encoding.UTF8; //domyślne kodowanie danych wyjściowych

            Interaction.MsgBox("Program Emerytura"); // wyskoczy okienko MsgBox okno plus przycisk OK.
            
            Console.WriteLine("Witam!.");
            string imie; 
            imie = Interaction.InputBox("Podaj imię", "Tytył okienka").Trim().ToUpper();

            // imie = Console.ReadLine().Trim().ToUpper();  //czyta strumień tekstowy, obcina i wpisuje z wielkiej litery. 
            string imiePierwszaLitera = imie.Substring(0, 1);
            string resztaImienia = imie.Substring(1);
            imie = imiePierwszaLitera.ToUpper() + resztaImienia.ToLower();
            Console.WriteLine("Witaj " + imie + "!");

           // Console.WriteLine("Podaj swoje nazwisko:");
           // string nazwisko = Console.ReadLine();

            string nazwisko = Interaction.InputBox("Podaj nazwisko", "Nazwisko").Trim().ToUpper();
            string pierwszaLitera = nazwisko.Substring(0, 1);
            string reszta = nazwisko.Substring(1); //nazwy substring możemy użyć w dwóch wariantach.
            nazwisko = pierwszaLitera.ToUpper() + reszta.ToLower(); // łączymy te dwa stringi
            
            Console.WriteLine($"Witaj, {imie} {nazwisko}"); ///ważne aby zmienne odwoływały się do istniejących zmiennych
            Console.WriteLine("Podaj swój wiek: ");
            int wiek = 0;
            string s = Interaction.InputBox("Podaj swój wiek", "Wiek"); //= Console.ReadLine();
            wiek = int.Parse(s);

            Console.WriteLine($"Masz {wiek} lat");
            if (wiek >= 65)
            {
                Console.WriteLine("Jesteś emerytem");
            }
            else
            {
                Console.WriteLine($"Do emerytury zostało ci {65 - wiek}");
            }
            Interaction.MsgBox($"Witaj, {imie} {nazwisko} \n do emerytury zostało ci {65 - wiek}");
        }
    }
}
