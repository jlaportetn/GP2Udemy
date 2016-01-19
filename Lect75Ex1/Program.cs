using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lect75Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberOfWords();
        }
        static void NumberOfWords()
        {
            var path = @"C:\Udemytext\sometext.txt";
            var readText = File.ReadAllText(path);
            var words = readText.Split(' ');

            if (!File.Exists(path))
            {
                return;
            }
            else
            {
                Console.WriteLine("The number of words is " + words.Length);
            }
        }
    }
}
