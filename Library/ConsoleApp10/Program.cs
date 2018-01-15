using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Loops
{
    class Program
    {
        // You did not prepare a PR, which means you are not interested in me looking through the code :(
        static void Main(string[] args)
        {
            string a, b, c, d, e, f, g;
            int h = 0;
            Console.Write("Do you want to use the program? Enter y/n: ");
            g = Console.ReadLine();
            while (g[h] == 'y')
            {
                Console.Write("Name of your book: ");
                a = Console.ReadLine();
                StreamWriter NewFile = File.CreateText(@"Library\" + a + ".txt");
                NewFile.WriteLine("Name: " + a);

                Console.Write("Author: ");
                b = Console.ReadLine();
                NewFile.WriteLine("Author: " + b);

                Console.Write("Year: ");
                c = Console.ReadLine();
                NewFile.WriteLine("Year: " + c);

                Console.Write("Number of pages: ");
                d = Console.ReadLine();
                NewFile.WriteLine("Pages: " + d);

                Console.Write("Price: ");
                e = Console.ReadLine();
                NewFile.WriteLine("Prise: " + e);

                Console.Write("Any comments: ");
                f = Console.ReadLine();
                NewFile.WriteLine("Comments: " + f);

                NewFile.Close();

                Console.Write("Do you want to add another one book? Enter y/n: ");
                g = Console.ReadLine();
            }
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
