using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lect75Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintLongestWord();
        }
        static void PrintLongestWord()
        {
            var path = @"C:\Udemytext\sometext.txt";
            var text = File.ReadAllText(path);
            var words = text.Split(' ');
            var longestWord = "";

            foreach (var word in words)
            {
                if (word.Length > longestWord.Length)
                {
                    longestWord = word;
                }
            }
            Console.WriteLine("The longest word is " + longestWord + ".");
            Console.ReadKey();
        }
    }
}
