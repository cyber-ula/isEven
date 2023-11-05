using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4Task1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("We check if your number is even or odd ;)");
            Console.WriteLine("Type your number:\n");

            var yourNumber = GetInput();
         
            if(yourNumber%2 == 0)
            { 
                Console.WriteLine("Your number is even.\n");
            }
            else
            {
                Console.WriteLine("Your number is odd.\n");
            }           
        }

        private static long GetInput()
        {
            while (true)
            {
                if (!long.TryParse(Console.ReadLine(), out long input))
                {
                    Console.WriteLine("Wrong value or your number is too big! Type an integer number:\n ");
                    continue;                   
                }
                return input;
            }
        }
    }
}
