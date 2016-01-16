using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect67Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a series of numbers separated by a hyphen");
            var numbers = Console.ReadLine();
            var numbers2 = string.Copy(numbers);

            if (string.IsNullOrEmpty(numbers))
            {
                Console.WriteLine("Nothing entered.");
            }
            var numbersList = new List<int>();
            numbersList = numbers2.Split('-').Select(Int32.Parse).ToList();
            List<int> checkForDup = numbersList.Distinct().ToList();

            if (numbersList.Count == checkForDup.Count)
            {
                Console.WriteLine("No duplicates entered.");
            }
            else
            {
                Console.WriteLine("Duplicate entered.");
            }
            Console.ReadKey();
        }
    }
}