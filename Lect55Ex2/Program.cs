using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect55Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");

            var name = Console.ReadLine();
            char[] nameAsArray = name.ToCharArray();
            Array.Reverse(nameAsArray);
            {
                Console.Write(nameAsArray);
                Console.ReadKey();
            }
        }
        }
    }

