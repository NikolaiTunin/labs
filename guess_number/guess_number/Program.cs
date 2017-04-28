using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guess_number
{
    class Program
    {
        static void Main()
        {
            int min = 1, max = 100000;
            Console.WriteLine("Imagine number in range {0} - {1}",min, max);

            while (max - min  > 1)
            {
                Console.WriteLine("\nIs your number larger {0} ? (y/n)", (max+min)/2);
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Y:
                        min = (max + min)/ 2;
                        break;
                    case ConsoleKey.N:
                        max = (max + min) / 2;
                        break;
                    default:
                        Console.WriteLine("\nWrong entry. Try again, please");
                        break;
                }
            }
            Console.WriteLine("\nIs your number {0}?", (max + min) / 2);
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Console.WriteLine("\nYour number is {0}", (max + min) / 2);
                Console.ReadKey();
            }
            else Console.WriteLine("\nIs your number {0}?", (max + min) / 2 + 1);
            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                Console.WriteLine("\nSUCCESS! Press any key\n");
            }
            else Console.WriteLine("\nNO WAY! Try again. Press any key\n");

            Console.ReadKey();
        }
    }
}
