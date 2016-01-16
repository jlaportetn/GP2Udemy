using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect67Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a series of numbers separated by a hyphen");
            var numbers = Console.ReadLine();
            var numbersList = new List<int>();
            numbersList = numbers.Split('-').Select(Int32.Parse).ToList();
            var sortedNumbers = new List<int>(numbersList);
            sortedNumbers.Sort();
        
            if (numbersList.SequenceEqual(sortedNumbers))
            {
                Console.WriteLine("Consecutive");
            }
            else
            {
                Console.WriteLine("Not consecutive");
            }
            Console.ReadKey();
        }
    }
}
