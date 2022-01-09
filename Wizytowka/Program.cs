using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wizytowka
{
    struct Pracownik {

        public string imie;
        public string nazwisko;
        public string email;
        public int telefon;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pracownik p;

            Console.WriteLine("Podaj imie: ");
            p.imie = Console.ReadLine();

            Console.WriteLine("Podaj nazwisko: ");
            p.nazwisko = Console.ReadLine();

            Console.WriteLine("Podaj email: ");
            p.email = Console.ReadLine();

            Console.WriteLine("Podaj numer telefonu: ");
            p.telefon = Convert.ToInt32(Console.ReadLine());

            /*
             * obserwacja: długość najdłuższego napisu + 4 = długość wizytówki
             * 1 połączyć imię z nazwiskiem i jedną spacją -> zmienna imienazwisko
             * 2 połączyć email z napisem "email"
             * 3 połączyć numer telefonu z napisem "tel. "
             * 4 obliczyć długości a = dlugosć napisu imienazwisko,b,c tych trzech napisów
             * 5 wybrać największą z tych długości -> maksimum
             * 6 nowa zmienna dlugoscWizytowki = maksimum + 4
             * 7 na przykład ilość spacji po obu stronach napisu imienazwisko obliczamy:
             * (dlugoscWizytowki - a)/2
             * 8 uwaga. Może powstać problem z niedokładnym wycentrowaniem z powodu błędu 
             * zaokrąglenia przy dzieleniu przez 2
             */

            string imienazwisko = p.imie + " " + p.nazwisko; // 1
            p.email = "e-mail:" + p.email; // 2
            string telefon = "tel. " + p.telefon; // 3

            int a = imienazwisko.Length;
            int b = p.email.Length;
            int c = telefon.Length; // 4
            int maksimum = Math.Max(Math.Max(a, b), c); // 5
            int dlugoscWizytowki = maksimum + 4; // 6

            // pętla rysująca gwiazdki
            for (int i = 0; i < dlugoscWizytowki; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            // 1 gwiazdka
            Console.Write("*");
            // seria spacji
            for (int i = 0; i < (dlugoscWizytowki - a - 2) / 2; i++)
            {
                Console.Write(" ");
            }

            // imienazwisko
            Console.Write(imienazwisko);
            // seria spacji
            for (int i = 0; i < (dlugoscWizytowki - a - 2) / 2; i++)
            {
                Console.Write(" ");
            }
            // 1 gwiazdka
            Console.Write("*");
            Console.WriteLine();

            //Console.WriteLine(p.imie);
            //Console.WriteLine(p.nazwisko);
            //Console.WriteLine(p.email);
            //Console.WriteLine(p.telefon);

            Console.ReadKey();
        }
    }
}
