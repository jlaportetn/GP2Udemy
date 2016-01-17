using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect67Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a word in English.");
            var userEntry = Console.ReadLine();
            var vowels = new List<char> { 'a', 'e', 'i', 'o', 'u' };
            var count = 0;

            foreach (char i in userEntry)
            {
                if (vowels.Contains(i))
                    count++;
            }
            Console.WriteLine("The number of vowels you entered is " + count);
            Console.ReadKey();
        }
    }
}
