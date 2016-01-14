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
            int numbersAsInt;
            Int32.TryParse(numbers, out numbersAsInt);

            while (numbers != "quit")
            {
                numbersList.Add(numbersAsInt);
                List<int> distict = numbersList.Distinct().ToList();
                foreach (int i in distict)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
