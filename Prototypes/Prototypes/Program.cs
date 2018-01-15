using System;

namespace Pprototypes
{
    class Program
    {
        static void Main(string[] args)
        {
            start:;
            int i, j;
            Console.WriteLine("Choose prototype that you want to use:");
            Console.WriteLine("1. Difference between value and reference types");
            Console.WriteLine("2. Variable scope");
            Console.WriteLine("3. Immutability");
            i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    ValRef();
                    break;
                case 2:
                    VarScope();
                    break;
                case 3:
                    Immut();
                    break;
            }
            Console.Write("Do you want to go to menu? Enter 1 if you want and 2 if not: ");
            j = int.Parse(Console.ReadLine());
            if (j == 1)
                goto start;
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }

        static void ValRef()
        {
            int a = 10;
            int[] b = new int[] { 20 };
            Console.WriteLine("By value type: " + a);
            Console.WriteLine("By reference type: " + b[0]);
        }

        static void VarScope()
        {
            var a = 1;
            Local();
            Global(a);
        }

        static void Local()
        {
            var a = 2;
            Console.WriteLine("Your local assigned a: " + a);
        }

        static void Global(int a)
        {
            Console.WriteLine("Your global assigned a: " + a);
        }

        static void Immut()
        {
            var i = 1;
            Mutab(i);
            Console.WriteLine("But the real value is immutable: " + i);
        }

        static string Mutab(int i)
        {
            string a = "";
            Console.WriteLine("Now it outputs: " + i);
            if (i < 10)
                return Mutab(++i);
            return a;
        }
    }
}