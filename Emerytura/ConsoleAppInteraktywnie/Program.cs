using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppInteraktywnie
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.InputEncoding = Encoding.UTF8;  // domyślne kopdowanie danych wejściowych'
            Console.OutputEncoding = Encoding.UTF8; //domyślne kodowanie danych wyjściowych
            // tu piszemy kod
            Console.WriteLine("Program emerytura");
            Console.WriteLine("Witam!.");
            Console.WriteLine("Podaj swoje imię: ");
            string imie;
            imie = Console.ReadLine();
            // imie = imie.Trim();    //przycinanie znaków musimy zadeklarować i musimy przypisać do jakiej zmiennej
            
            
            //POTOKOWE PRZETWARZANIE DANYCH.
            imie = Console.ReadLine().Trim().ToUpper();  //czyta strumień tekstowy, obcina i wpisuje z wielkiej litery. 


            //Console.WriteLine("Witaj " + imie +"!");
            Console.WriteLine("Podaj swoje nazwisko:");
            string nazwisko = Console.ReadLine();
            string pierwszaLitera = nazwisko.Substring(0, 1);
            string reszta = nazwisko.Substring(1); //nazwy substring możemu użyć w dwóch wariantach.
            nazwisko = pierwszaLitera.ToUpper() + reszta.ToLower(); // łączymy te dwa stringi


            //Console.WriteLine("Witaj " + imie + " " + nazwisko); //najgorze rozwiązanei to sklejanie napisów za pomoca plusa
            
            Console.WriteLine("Witaj, {0} {1}! ",nazwisko, imie );    // szablon {0} odpowiada nazwisko {1} odpowiada imię String Formatowany
            
            // string interpolowany 3 sposób budowania napisów. NAGMINNIE STOSOWANY.
            
            Console.WriteLine($"Witaj, {imie} {nazwisko}"); ///ważne aby zmienne odwoływały się do istniejących zmiennych
            Console.WriteLine("Podaj swój wiek: ");
            int wiek = 0;
            //  wiek = Console.ReadLine();      NIE MOŻE PRZEKONWERTOWAC TEKST NA LICZBĘ.

            string s = Console.ReadLine();
            wiek = int.Parse(s);    
            // Parse konwertuje zmienną dany wzorzec.   Gdy wprowadzimy dane nie mieszczące w danym typie zmiennej
            // pojawi się nie BŁĄD ale w tym języku i w jawie WYJĄTEK 
            Console.WriteLine($"Masz {wiek} lat");

            // jeżeli wiek > 65 to jesteś emerytem a w przeciwnym wypadku  do emerytury został ci 65 - wiek
            if (wiek >= 65)
            {
                Console.WriteLine("Jesteś emerytem");
            }
            else
            {
                Console.WriteLine($"Do emerytury zostało ci {65 - wiek}");
            }













            
        }
    }
}
