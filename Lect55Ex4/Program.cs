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

            if (numbers == "quit")
            {
                Console.ReadKey();
            }
            else
            {
                var numbersList = new List<int>();
                numbersList = numbers.Split(' ').Select(Int32.Parse).ToList();
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
