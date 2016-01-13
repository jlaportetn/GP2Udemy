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
            //Still working on this solution
            Console.WriteLine("Please enter a sequence of numbers, or type quit to exit.");
            var numbers = (Console.ReadLine());
            var numbersList = new List<int>();

            while (numbers != "quit")
            {
                int numbersAsInt = Int32.TryParse(numbers, out numbersAsInt);
                numbersList.Add(numbersAsInt);
                numbers = Console.ReadLine();
                List<int> Distinct = numbersList.Distinct().ToList();

                foreach (int i in Distinct)
                {
                    Console.WriteLine(i);
                }
                Console.ReadKey();
            }
        }
    }
}
