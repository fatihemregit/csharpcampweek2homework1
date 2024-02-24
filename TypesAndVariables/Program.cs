using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Hello World!");

            double number5 = 10.4;
            decimal number6 = 10.4m;
            char character = 'A';
            bool condition = false;
            byte number4 = 255;
            short number3 = 32767;
            int number1 = 2147483647;
            long number2 = 2147483648;
            var number7 = 10;
            number7 = 'A';
            Console.WriteLine($"Number1 is {number1}");
            Console.WriteLine($"Number2 is {number2}");
            Console.WriteLine($"Number3 is {number3}");
            Console.WriteLine($"Number4 is {number4}");
            Console.WriteLine($"Number5 is {number5}");
            Console.WriteLine($"Number7 is {number7}");

            Console.WriteLine($"Character is : {(int)character}");
            
            Console.WriteLine(Days.Friday);
            Console.ReadLine();
        }

    }
    enum Days
    {
        Monday = 10,Tuesday = 20, Wednesday = 30,Thursday,Friday,Saturday,Sunday
    }


}
