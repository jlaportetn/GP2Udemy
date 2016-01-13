using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect55Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 5 numbers with no duplicates.");
            var numbers =(Console.ReadLine());
            var numbersList = new List<int>();
            numbersList = numbers.Split(' ').Select(Int32.Parse).ToList();
            List<int> Distinct = numbersList.Distinct().ToList();

            if (Distinct.Count < 5) 
            {
                Console.WriteLine("Duplicate entered, or not enough numbers entered.  Please try again.");
                Console.ReadKey();
            }
            else
            {
                Distinct.Sort();
                Console.WriteLine("Sorted numbers");
                foreach (int i in Distinct)
                Console.WriteLine(i);
                Console.ReadKey();
            }
        }
    }
}
