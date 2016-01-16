using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect67Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a time using the 24 hour format.");
            var userTime = Console.ReadLine();
            TimeSpan time;

            if (TimeSpan.TryParse(userTime, out time))
            {
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
            Console.ReadKey();
        }
    }
}
