using System;

namespace SedgewickLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            start:;
            Console.WriteLine("Choose program that you want to test:\n");
            Console.WriteLine("Enter 1 for \n1.3.1 Write a program that takes three integer command-line arguments and prints equal if all three are equal, and not equal otherwise.\n");
            Console.WriteLine("Enter 2 for \n1.3.5 Improve your solution to EXERCISE 1.2.25 by adding code to check that the values of the command - line arguments fall within the ranges of validity of the formula, and also adding code to print out an error message if that is not the case.\n");
            Console.WriteLine("Enter 3 for \n1.3.8 Write a program that, using one for loop and one if statement, prints the integers from 1,000 to 2,000 with five integers per line. Hint: Use the % operation.\n");
            Console.WriteLine("Enter 4 for \n1.3.11 Write a program FunctionGrowth that prints a table of the values log N, N, N log N, N 2, N 3, and 2 N for N = 16, 32, 64, ... , 2048.\n");
            Console.WriteLine("Enter 5 for \n1.3.14 Write a program that takes a command-line argument N and prints all the positive powers of two less than or equal to N.Make sure that your program works properly for all values of N. (Integer.parseInt() will generate an error if N is too large, and your program should print nothing if N is negative.) \n");
            Console.WriteLine("Enter 6 for \n1.3.27 Write a program Checkerboard that takes one command-line argument N and uses a loop within a loop to print out a two-dimensional N - by - N checkerboard pattern with alternating spaces and asterisks.\n");
            Console.WriteLine("Enter 7 for \n1.3.28 Write a program GCD that finds the greatest common divisor(gcd) of two integers using Euclid’s algorithm, which is an iterative computation based on the following observation: if x is greater than y, then if y divides x, the gcd of x and y is y; otherwise, the gcd of x and y is the same as the gcd of x % y and y.\n");
            Console.WriteLine("Enter 8 for \n1.3.30 Write a program PowersOfK that takes an integer k as command - line argument and prints all the positive powers of k in the Java long data type.Note : The constant Long.MAX_VALUE is the value of the largest integer in long.\n");
            Console.WriteLine("Enter 9 for \n1.3.32 Ramanujan’s taxi. Srinivasa Ramanujan was an Indian mathematician who became famous for his intuition for numbers.When the English mathematician G.H.Hardy came to visit him one day, Hardy remarked that the number of his taxi was 1729, a rather dull number.To which Ramanujan replied, “No, Hardy! No, Hardy!It is a very interesting number.It is the smallest number expressible as the sum of two cubes in two different ways.” Verify this claim by writing a program that takes a command - line argument N and prints out all integers less than or equal to N that can be expressed as the sum of two cubes in two different ways.In other words, find distinct positive integers a, b, c, and d such that a3 + b3 = c3 + d3.Use four nested for loops.\n");
            Console.WriteLine("Enter 10 for \n1.3.33 Checksum.The International Standard Book Number(ISBN) is a 10 - digit code that uniquely specifies a book.The rightmost digit is a checksum digit that can be uniquely determined from the other 9 digits, from the condition that d1 + 2d2 + 3d3 + ... + 10d10 must be a multiple of 11(here di denotes the ith digit from the right).The checksum digit di can be any value from 0 to 10.The ISBN convention is to use the character 'X' to denote 10.Example: the checksum digit corresponding to 020131452 is 5 since 5 is the only value of x between 0 and 10 for which 10·0 + 9·2 + 8·0 + 7·1 + 6·3 + 5·1 + 4·4 + 3·5 + 2·2 + 1·x is a multiple of 11.Write a program that takes a 9 - digit integer as a command - line argument, computes the checksum, and prints out the the ISBN number.\n");
            Console.WriteLine("Enter 11 for \n1.3.34 Counting primes. Write a program PrimeCounter that takes a commandline argument N and finds the number of primes less than or equal to N.Use it to print out the number of primes less than or equal to 10 million.Note : if you are not careful, your program may not finish in a reasonable amount of time!\n");
            Console.WriteLine("Enter 12 for \n1.3.35 2D random walk. A two-dimensional random walk simulates the behavior of a particle moving in a grid of points.At each step, the random walker moves north, south, east, or west with probability equal to 1 / 4, independent of previous moves.Write a program RandomWalker that takes a command - line argument N and estimates how long it will take a random walker to hit the boundary of a 2N - by - 2N square centered at the starting point.\n");
            Console.WriteLine("Enter 13 for \n1.3.39 Pepys problem. In 1693 Samuel Pepys asked Isaac Newton which is more likely: getting 1 at least once when rolling a fair die six times or getting 1 at least twice when rolling it 12 times.Write a program that could have provided Newton with a quick answer.\n");
            Console.WriteLine("Enter 14 for \n1.3.40 Game simulation. In the 1970s game show Let’s Make a Deal, a contestant is presented with three doors.Behind one of them is a valuable prize.After the contestant chooses a door, the host opens one of the other two doors(never revealing the prize, of course).The contestant is then given the opportunity to switch to the other unopened door. Should the contestant do so? Intuitively, it might seem that the contestant’s initial choice door and the other unopened door are equally likely to contain the prize, so there would be no incentive to switch.Write a program MonteHall to test this intuition by simulation.Your program should take a commandline argument N, play the game N times using each of the two strategies(switch or do not switch), and print the chance of success for each of the two strategies.\n");
            Console.WriteLine("Enter 15 for \n1.3.41 Median-of-5. Write a program that takes five distinct integers from the command line and prints the median value(the value such that two of the others are smaller and two are larger).Extra credit: Solve the problem with a program that compares values fewer than seven times for any given input.\n");
            Console.WriteLine("Enter 16 for \n1.3.44 Euler’s sum-of-powers conjecture. In 1769 Leonhard Euler formulated a generalized version of Fermat’s Last Theorem, conjecturing that at least n nth powers are needed to obtain a sum that is itself an nth power, for n > 2.Write a program to disprove Euler’s conjecture(which stood until 1967), using a quintuply nested loop to find four positive integers whose 5th power sums to the 5th power of another positive integer. That is, find a, b, c, d, and e such that a 5 + b 5 + c 5 + d 5 = e 5. Use the long data type.\n");
            var i = int.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    var tp1r = tp1() ? "Equal" : "Not equal";
                    Console.WriteLine($"Test: {tp1r}");
                    break;
                case 2:
                    var tp2r = tp2() ? "Error" : "Pass";
                    Console.WriteLine($"Test: {tp2r}");
                    break;
                case 3:
                    var tp3r = tp3() ? "Pass" : "Fail";
                    Console.WriteLine($"Test: {tp3r}");
                    break;
                case 4:
                    var tp4r = tp4() ? "Pass" : "Fail";
                    Console.WriteLine($"Test: {tp4r}");
                    break;
                case 5:
                    var tp5r = tp5() ? "Pass" : "Fail";
                    Console.WriteLine($"Test: {tp5r}");
                    break;
                case 6:
                    var tp6r = tp6() ? "Pass" : "Fail";
                    Console.WriteLine($"Test: {tp6r}");
                    break;
                case 7:
                    var tp7r = tp7() ? "Pass" : "Fail";
                    Console.WriteLine($"Test: {tp7r}");
                    break;
                case 8:
                    var tp8r = tp8() ? "Pass" : "Fail";
                    Console.WriteLine($"Test: {tp8r}");
                    break;
                case 9:
                    var tp9r = tp9() ? "Pass" : "Fail";
                    Console.WriteLine($"Test: {tp9r}");
                    break;
                case 10:
                    var tp10r = tp10() ? "Can't unblock with this code" : "Pass";
                    Console.WriteLine($"Test: {tp10r}");
                    break;
                case 11:
                    var tp11r = tp11() ? "Pass" : "Fail";
                    Console.WriteLine($"Test: {tp11r}");
                    break;
                case 12:
                    var tp12r = tp12() ? "Pass" : "Fail";
                    Console.WriteLine($"Test: {tp12r}");
                    break;
                case 13:
                    var tp13r = tp13() ? "Pass" : "Fail";
                    Console.WriteLine($"Test: {tp13r}");
                    break;
                case 14:
                    var tp14r = tp14() ? "Pass" : "Fail";
                    Console.WriteLine($"Test: {tp14r}");
                    break;
                case 15:
                    var tp15r = tp15() ? "Pass" : "Fail";
                    Console.WriteLine($"Test: {tp15r}");
                    break;
                case 16:
                    var tp16r = tp16() ? "Pass" : "Fail";
                    Console.WriteLine($"Test: {tp16r}");
                    break;
            }
            Console.Write("Do you want to test another task? y/n: ");
            var j = char.Parse(Console.ReadLine());
            if (j == 'y')
                goto start;
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }

        static bool tp1()
        {
            return pp1() == "Equal";
        }

        static string pp1()
        {
            var ans = p1();
            return ans;
        }

        static string p1()
        {
            /*1.3.1 Write a program that takes three integer command-line arguments and
                        prints equal if all three are equal, and not equal otherwise.*/
            Console.WriteLine("Enter 3 numbers:");
            var a = "";
            var arg1 = int.Parse(Console.ReadLine());
            var arg2 = int.Parse(Console.ReadLine());
            var arg3 = int.Parse(Console.ReadLine());
            if (arg1 == arg2 && arg2 == arg3)
                a = "Equal";
            else
                a = "Not equal";
            return a;
        }

        static bool tp2()
        {
            return pp2() == 1;
        }

        static double pp2()
        {
            var ans = p2();
            return ans;
        }

        static double p2()
        {
            /*1.3.5 Improve your solution to EXERCISE 1.2.25 by adding code to check that the
            values of the command-line arguments fall within the ranges of validity of the formula,
            and also adding code to print out an error message if that is not the case.*/
            var a = 0.0;
            Console.WriteLine("Enter the temperature: ");
            var temp = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the wind speed: ");
            var speed = int.Parse(Console.ReadLine());
            if (temp < 50 && speed < 120 && speed > 3)
            {
                a = (35.74 + 0.6215 * temp + (0.4275 * temp - 35.75) * Math.Pow(speed, 0.16));
                Console.WriteLine(a);
            }
            else
                a = 1;
            return a;
        }

        static bool tp3()
        {
            return pp3() == 1;
        }

        static int pp3()
        {
            var ans = p3();
            return ans;
        }

        static int p3()
        {
            /*1.3.8 Write a program that, using one for loop and one if statement, prints the integers from 1,000 to 2,000 with five integers per line. Hint: Use the % operation.*/
            for (var i = 1000; i <= 2000; i++)
            {
                if (i % 5 == 0)
                    Console.WriteLine(i);
                else
                    Console.Write(i + " ");
            }
            var a = 1;
            return a;
        }

        static bool tp4()
        {
            return pp4() == 1;
        }

        static int pp4()
        {
            var ans = p4();
            return ans;
        }

        static int p4()
        {
            /*1.3.11 Write a program FunctionGrowth that prints a table of the values log N,
            N, N log N, N 2, N 3, and 2 N for N = 16, 32, 64, ... , 2048.*/
            int[] N = new int[] { 16, 32, 64, 128, 256, 512, 1024, 2048 };
            Console.WriteLine("N: " + N[0] + " " + N[1] + " " + N[2] + " " + N[3] + " " + N[4] + " " + N[5] + " " + N[6] + " " + N[7]);
            Console.WriteLine("logN: " + Math.Log(N[0]) + " " + Math.Log(N[1]) + " " + Math.Log(N[2]) + " " + Math.Log(N[3]) + " " + Math.Log(N[4]) + " " + Math.Log(N[5]) + " " + Math.Log(N[6]) + " " + Math.Log(N[7]));
            Console.WriteLine("N*logN: " + N[0] * Math.Log(N[0]) + " " + N[1] * Math.Log(N[1]) + " " + N[2] * Math.Log(N[2]) + " " + N[3] * Math.Log(N[3]) + " " + N[4] * Math.Log(N[4]) + " " + N[5] * Math.Log(N[5]) + " " + N[6] * Math.Log(N[6]) + " " + N[7] * Math.Log(N[7]));
            Console.WriteLine("N^2: " + N[0] * N[0] + " " + N[1] * N[1] + " " + N[2] * N[2] + " " + N[3] * N[3] + " " + N[4] * N[4] + " " + N[5] * N[5] + " " + N[6] * N[6] + " " + N[7] * N[7]);
            Console.WriteLine("N^3: " + N[0] * N[0] * N[0] + " " + N[1] * N[1] * N[1] + " " + N[2] * N[2] * N[2] + " " + N[3] * N[3] * N[3] + " " + N[4] * N[4] * N[4] + " " + N[5] * N[5] * N[5] + " " + N[6] * N[6] * N[6] + " " + N[7] * N[7] * N[7]);
            Console.WriteLine("2^N: " + Math.Pow(2, N[0]) + " " + Math.Pow(2, N[1]) + " " + Math.Pow(2, N[2]) + " " + Math.Pow(2, N[3]) + " " + Math.Pow(2, N[4]) + " " + Math.Pow(2, N[5]) + " " + Math.Pow(2, N[6]) + " " + Math.Pow(2, N[7]));
            var a = 1;
            return a;
        }

        static bool tp5()
        {
            return pp5() == 1;
        }

        static int pp5()
        {
            var ans = p5();
            return ans;
        }

        static int p5()
        {
            /*1.3.14 Write a program that takes a command-line argument N and prints all the
            positive powers of two less than or equal to N. Make sure that your program works
            properly for all values of N. (Integer.parseInt() will generate an error if N is too
            large, and your program should print nothing if N is negative.)*/
            Console.WriteLine("Enter the value of n:");
            var n = int.Parse(Console.ReadLine());
            for (var i = 2; i <= n; i = i * 2)
            {
                Console.Write(i + " ");
            }
            var a = 1;
            return a;
        }

        static bool tp6()
        {
            return pp6() == 1;
        }

        static int pp6()
        {
            var ans = p6();
            return ans;
        }

        static int p6()
        {
            /*1.3.27 Write a program Checkerboard that takes one command-line argument N
           and uses a loop within a loop to print out a two-dimensional N-by-N checkerboard
           pattern with alternating spaces and asterisks.*/
            Console.Write("Enter the number for making checkerboard: ");
            var c = int.Parse(Console.ReadLine());
            for (var i = 0; i < c; i++)
            {
                if (i % 2 != 0)
                    Console.Write(" ");
                for (var j = 0; j < c / 2; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            var a = 1;
            return a;
        }

        static bool tp7()
        {
            return pp7() == 1;
        }

        static int pp7()
        {
            var ans = p7();
            return ans;
        }

        static int p7()
        {
            /*1.3.28 Write a program GCD that finds the greatest common divisor(gcd) of two
            integers using Euclid’s algorithm, which is an iterative computation based on the
            following observation: if x is greater than y, then if y divides x, the gcd of x and y is
            y; otherwise, the gcd of x and y is the same as the gcd of x % y and y.*/
            var t = 0;
            Console.WriteLine("Enter 2 numbers for GCD:");
            var z = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            while (x != 0)
            {
                t = x;
                x = z % x;
                z = t;
            }
            Console.WriteLine("GCD: " + z);
            var a = 1;
            return a;
        }

        static bool tp8()
        {
            return pp8() == 1;
        }

        static int pp8()
        {
            var ans = p8();
            return ans;
        }

        static int p8()
        {
            /*1.3.30 Write a program PowersOfK that takes an integer k as command - line argument
             and prints all the positive powers of k in the Java long data type.Note : The
            constant Long.MAX_VALUE is the value of the largest integer in long.*/
            Console.Write("Enter the number:");
            var k = int.Parse(Console.ReadLine());
            for (var i = 1; i <= 31; i++)
            {
                if (Math.Pow(k, i) > 2147483647)
                    goto cont;
                Console.WriteLine(Math.Pow(k, i));
            }
            cont:;
            var a = 1;
            return a;
        }

        static bool tp9()
        {
            return pp9() == 1;
        }

        static int pp9()
        {
            var ans = p9();
            return ans;
        }

        static int p9()
        {
            /*1.3.32 Ramanujan’s taxi. Srinivasa Ramanujan was an Indian mathematician
            who became famous for his intuition for numbers.When the English mathematician
            G.H.Hardy came to visit him one day, Hardy remarked that the number of
            his taxi was 1729, a rather dull number.To which Ramanujan replied, “No, Hardy!
            No, Hardy!It is a very interesting number.It is the smallest number expressible as
            the sum of two cubes in two different ways.” Verify this claim by writing a program
            that takes a command - line argument N and prints out all integers less than or equal
            to N that can be expressed as the sum of two cubes in two different ways.In other
            words, find distinct positive integers a, b, c, and d such that a3 + b3 = c3 + d3.Use four
            nested for loops.*/
            var d = 0.0;
            var q = 0;
            Console.Write("Enter the number:");
            var s = int.Parse(Console.ReadLine());
            for (var j = 1; j < s; j++)
            {
                for (var i = 1; i < j; i++)
                {
                    d = j - i * i * i;
                    if (Math.Pow(j, 1 / 3) is int)
                        q++;
                    if (q == 2)
                    {
                        Console.WriteLine(j + " ");
                        break;
                    }
                }
            }
            var a = 1;
            return a;
            //Doesn't work correctly. Can't understand what's the mistake. Let's discuss it tomorrow
        }

        static bool tp10()
        {
            return pp10() == 10;
        }

        static int pp10()
        {
            var ans = p10();
            return ans;
        }

        static int p10()
        {
            /*1.3.33 Checksum.The International Standard Book Number(ISBN) is a 10 - digit
            code that uniquely specifies a book. The rightmost digit is a checksum digit that
            can be uniquely determined from the other 9 digits, from the condition that d1 +
            2d2 + 3d3 + ... + 10d10 must be a multiple of 11(here di denotes the ith digit from the
            right).The checksum digit di can be any value from 0 to 10.The ISBN convention is
            to use the character 'X' to denote 10.Example: the checksum digit corresponding
            to 020131452 is 5 since 5 is the only value of x between 0 and 10 for which
            10·0 + 9·2 + 8·0 + 7·1 + 6·3 + 5·1 + 4·4 + 3·5 + 2·2 + 1·x
            is a multiple of 11.Write a program that takes a 9 - digit integer as a command - line
            argument, computes the checksum, and prints out the the ISBN number.*/
            Console.Write("Enter a 9-digit integer: ");
            var w = int.Parse(Console.ReadLine());
            var a1 = w % 10;
            var a2 = (w % 100 - a1) / 10;
            var a3 = (w % 1000 - a1 - a2) / 100;
            var a4 = (w % 10000 - a1 - a2 - a3) / 1000;
            var a5 = (w % 100000 - a1 - a2 - a3 - a4) / 10000;
            var a6 = (w % 1000000 - a1 - a2 - a3 - a4 - a5) / 100000;
            var a7 = (w % 10000000 - a1 - a2 - a3 - a4 - a5 - a6) / 1000000;
            var a8 = (w % 100000000 - a1 - a2 - a3 - a4 - a5 - a6 - a7) / 10000000;
            var a9 = (w % 1000000000 - a1 - a2 - a3 - a4 - a5 - a6 - a7 - a8) / 100000000;
            var e = (88 - (a1 + a2 + a3 + a4 + a5 + a6 + a7 + a8 + a9)) % 11;
            if (e > 9)
            {
                var a = 10;
                return a;
            }
            Console.WriteLine(e);
            return e;
            //Didn't correct to cycles
        }

        static bool tp11()
        {
            return pp11() == 1;
        }

        static int pp11()
        {
            var ans = p11();
            return ans;
        }

        static int p11()
        {
            /*1.3.34 Counting primes. Write a program PrimeCounter that takes a commandline
            argument N and finds the number of primes less than or equal to N. Use it to
            print out the number of primes less than or equal to 10 million.Note : if you are not
            careful, your program may not finish in a reasonable amount of time!*/
            Console.Write("1 ");
            for (var i = 2; i <= 10000000; i++)
            {
                var r = 0;
                for (var j = 2; j <= i/2; j++)
                {
                    if (i % j == 0)
                        r++;
                    if (r > 0)
                        break;
                }
                if (r == 0)
                    Console.Write(i + " ");
            }
            var a = 1;
            return a;
            //I updated my code, now it runs much more fastly than previous time but it is not that we need I think
        }

        static bool tp12()
        {
            return pp12() == 1;
        }

        static int pp12()
        {
            var ans = p12();
            return ans;
        }

        static int p12()
        {
            /*1.3.35 2D random walk. A two-dimensional random walk simulates the behavior
            of a particle moving in a grid of points. At each step, the random walker moves
            north, south, east, or west with probability equal to 1/4, independent of previous
            moves. Write a program RandomWalker that takes a command-line argument N and
            estimates how long it will take a random walker to hit the boundary of a 2N-by-2N
            square centered at the starting point.*/
            Console.Write("Enter n: ");
            var a = 0;
            var b = 0;
            var c = 0;
            var n = int.Parse(Console.ReadLine());
            while (a != n || b != n)
            {
                Random rnd = new Random();
                var d = rnd.Next(0, 5);
                if (d == 1)
                    a++;
                if (d == 2)
                    b++;
                if (d == 3)
                    a--;
                if (d == 4)
                    b--;
                c++;
            }
            Console.WriteLine(c);
            var q = 1;
            return q;
        }

        static bool tp13()
        {
            return pp13() == 1;
        }

        static int pp13()
        {
            var ans = p13();
            return ans;
        }

        static int p13()
        {
            /*1.3.39 Pepys problem. In 1693 Samuel Pepys asked Isaac Newton which is more
            likely: getting 1 at least once when rolling a fair die six times or getting 1 at least
            twice when rolling it 12 times. Write a program that could have provided Newton
            with a quick answer.*/
            var k = 0;
            var l = 0;
            var b = 0;
            var c = 0;
            Random rnd = new Random();
            for (var j = 0; j < 6; j++)
            {
                var i = rnd.Next(0, 7);
                if (i == 1)
                    k++;
                l++;
                if (k == 1)
                {
                    Console.WriteLine("Number of tries: " + l);
                    break;
                }
            }
            if (k == 0)
                Console.WriteLine("You haven't got any 1");

            for (var j = 0; j < 12; j++)
            {
                var i = rnd.Next(0, 7);
                if (i == 1)
                    b++;
                c++;
                if (b == 2)
                {
                    Console.WriteLine("Number of tries: " + c);
                    break;
                }
            }
            if (b < 2)
                Console.WriteLine("You haven't got 1 twice");
            var a = 1;
            return a;
        }

        static bool tp14()
        {
            return pp14() == 1;
        }

        static int pp14()
        {
            var ans = p14();
            return ans;
        }

        static int p14()
        {
            /*1.3.40 Game simulation. In the 1970s game show Let’s Make a Deal, a contestant
            is presented with three doors. Behind one of them is a valuable prize. After the contestant
            chooses a door, the host opens one of the other two doors (never revealing
            the prize, of course). The contestant is then given the opportunity to switch to the
            other unopened door. Should the contestant do so? Intuitively, it might seem that
            the contestant’s initial choice door and the other unopened door are equally likely
            to contain the prize, so there would be no incentive to switch. Write a program MonteHall
            to test this intuition by simulation. Your program should take a commandline
            argument N, play the game N times using each of the two strategies (switch or
            do not switch), and print the chance of success for each of the two strategies.*/
            var b = 0;
            var c = 0;
            var d = 0;
            var e = 0;
            Random rnd = new Random();
            Console.Write("Enter n: ");
            var n = int.Parse(Console.ReadLine());
            for (var i = 0; i < n; i++)
            {
                var a = rnd.Next(0, 2);
                if (a == 1)
                    b++;
                if (a == 0)
                    c++;
            }
            Console.WriteLine("For not switch strategy chance of success is: " + Math.Min(b, c) * 100 / Math.Max(b, c) + "%");
            for (var i = 0; i < n; i++)
            {
                var a = rnd.Next(0, 2);
                if (a == 1)
                    e++;
                if (a == 0)
                    d++;
            }
            Console.WriteLine("For switch strategy chance of success is: " + Math.Min(e, d) * 100 / Math.Max(e, d) + "%");
            var q = 1;
            return q;
        }

        static bool tp15()
        {
            return pp15() == 1;
        }

        static int pp15()
        {
            var ans = p15();
            return ans;
        }

        static int p15()
        {
            /*1.3.41 Median-of-5. Write a program that takes five distinct integers from the
            command line and prints the median value (the value such that two of the others
            are smaller and two are larger). Extra credit : Solve the problem with a program that
            compares values fewer than seven times for any given input.*/

            //The problem is that the smallest number of compares I got is 10. It's not difficult code. All the difficulty is in algoritm, in method.

            var q = 1;
            return q;
        }

        static bool tp16()
        {
            return pp16() == 1;
        }

        static int pp16()
        {
            var ans = p16();
            return ans;
        }

        static int p16()
        {
            /*1.3.44 Euler’s sum-of-powers conjecture. In 1769 Leonhard Euler formulated a
            generalized version of Fermat’s Last Theorem, conjecturing that at least n nth powers
            are needed to obtain a sum that is itself an nth power, for n > 2. Write a program
            to disprove Euler’s conjecture (which stood until 1967), using a quintuply nested
            loop to find four positive integers whose 5th power sums to the 5th power of another
            positive integer. That is, find a, b, c, d, and e such that a 5 " b 5 " c 5 " d 5 * e 5.
            Use the long data type.*/
            long a, b, c, d, e;

            /*No idea how to make this. I wanted to do 4 for loops and check every number starting from 1 but I don't know until what I should do that. I mean check is it some number in 5 power like these:
            {1, 1, 1, 1}, {2, 1, 1, 1}, {3, 1, 1, 1}, ...
            And there will be very huge code to check these. I'm sure it should be more pretty and short.*/

            var q = 1;
            return q;
        }
        //1.3.32, 1.3.41, 1.3.44 - we should discuss
    }
}
