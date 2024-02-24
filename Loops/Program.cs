using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();

            //WhileLoop();
            //DoWhileLoop();
            //ForEachLoop();
            int number = 7;
            string durum = IsPrimeNumber(number) ? "Asaldır" : "Asal Değildir";
            Console.WriteLine($"{number} sayısı {durum}");

            Console.ReadLine();
        }

        private static bool IsPrimeNumber(int number) {
            //benim çözümüm bu şekilde
            if ((number <= 0) || (number == 1))
            {
                //(ilk parantez için)sadece pozitif sayılarda asallık aranır
                //(ikinci parantez için) (özel durum) 1 sayısı asal değildir
                return false;
            }

            List<int> bolunebilenler = new List<int>();
            for (int i = 1;i <= number; i++)
            {
                if (number % i == 0) {
                    bolunebilenler.Add(i);
                }

            }
            return !(bolunebilenler.Count > 2);
        
        }

        private static void ForEachLoop()
        {
            string[] students = new string[3] { "Fatih", "Emre", "Samet" };
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number >= 11);
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine($"now number is {number}");
        }

        private static void ForLoop()
        {
            for (int i = 100; i >= 0; i = i - 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
