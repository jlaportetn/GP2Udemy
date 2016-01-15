using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect55Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please entera series of 5 or more numbers, sseparated by a comma." );
            var input = Console.ReadLine();
            var numbers = new List<int>();
            numbers = input.Split(',').Select(Int32.Parse).ToList();

            if (numbers.Count < 5)
            {
                Console.WriteLine("Not enough numbers, try again");
            }
            else
            {
                numbers.Sort(); 
                Console.WriteLine("The three smallest numbers are " + numbers[0] + numbers[1] + numbers[2]);
            }
            Console.ReadKey();

        }
    }
}
