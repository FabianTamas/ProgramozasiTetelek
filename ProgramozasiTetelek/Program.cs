using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramozasiTetelek
{
    class Program
    {
        static int[] tomb = new int[10] { 12, 7, 2, 4, 45, 99, 1, 8, 95, 50 };

        static void TombKiiras()
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i] + ", ");
            }
        }

        static void Osszegzes()
        {
            int osszeg = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                osszeg += tomb[i];
            }
            Console.WriteLine();
            Console.WriteLine("A tömb elemeinek összege: {0}", osszeg);

        }

        static void Megszamolas()
        {
            int db = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i]%3 == 0)
                {
                    db++;
                }
            }
            Console.WriteLine("3-al osztható számok: {0}", db);
        }

        static void Eldontes()
        {
            int i = 0;
            while (i<tomb.Length && i !=69)
            {
                i++;
            }
            if (i<tomb.Length)
            {
                Console.WriteLine("Van 69");
            }
            else Console.WriteLine("Nincs 69");
        }

        static void Kivalasztas()
        {
            int i = 0;
            while (i<tomb.Length && tomb[i] != 50)
            {
                i++;
            }
            Console.WriteLine("Az 50 a {0}. helyen van", i+1);
        }
        static void Main(string[] args)
        {
            TombKiiras();
            Osszegzes();
            Megszamolas();
            Eldontes();
            Kivalasztas();

            Console.ReadKey();
        }
    }
}
