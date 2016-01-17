using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect67Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a series of words.");
            var userEntry = Console.ReadLine();
            var entryAsList = new List<string>();
            entryAsList = userEntry.Split(' ').ToList();

            foreach (var word in entryAsList)
            {
               var pascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1); 
               Console.Write(pascalCase);
            }
            Console.ReadKey();
        }
    }
}
