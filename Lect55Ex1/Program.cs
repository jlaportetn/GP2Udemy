using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lect55Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the names of friends that liked you post, press enter when complete");

            var userEntry = Console.ReadLine();
            var listOfNames = new List<string>();
            listOfNames = userEntry.Split(' ').ToList();

            if (listOfNames.Count == 1)
            {
                Console.WriteLine(listOfNames[0] + " Liked your post");
            }
            else if (listOfNames.Count == 2)
            {
                Console.WriteLine(listOfNames[0] + " and "  + listOfNames[1] + " Liked your post." );
            }
            else if  (listOfNames.Count > 2)
            {
                Console.WriteLine(listOfNames[0] + ", " + listOfNames[1] + ", and " + (listOfNames.Count - 2) + " other friends liked your post" );
            }
            Console.ReadKey();
        }
    }
}
