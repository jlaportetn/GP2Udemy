using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect55Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a sequence of numbers, or type quit to exit.");
            var numbers = (Console.ReadLine());
            var numbersList = new List<int>();

            while (numbers != "quit")
            {
                int numbersAsInt;

                if (Int32.TryParse(numbers, out numbersAsInt) == true)
                {
                    numbersList.Add(numbersAsInt);
                    List<int> distinct = numbersList.Distinct().ToList();
                    Console.WriteLine("The unique numbers you entered are ");
                    foreach (int i in distinct)
                    {
                        Console.WriteLine(i);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid entry");
                }
                numbers = Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
