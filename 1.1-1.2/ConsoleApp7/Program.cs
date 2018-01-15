using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.1.1 Write a program that prints the Hello, World message 10 times.
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello. World");
            }

            //1.1.5 Modify UseArgument.java to make a program UseThree.java that takes three names and prints out a proper sentence with the names in the reverse of the order given, so that, for example, java UseThree Alice Bob Carol gives Hi Carol, Bob, and Alice.
            string name1, name2, name3;
            Console.WriteLine("Write 3 names: ");
            name1 = Console.ReadLine();
            name2 = Console.ReadLine();
            name3 = Console.ReadLine();
            Console.WriteLine("Hi, " + name3 + " " + name2 + " " + name1);

            //1.2.2 Write a program that uses Math.sin() and Math.cos() to check that the value of cos2 & +sin2 & is approximately 1 for any & entered as a command - line argument. Just print the value.Why are the values not always exactly 1 ?
            double q, result;
            Console.WriteLine("Enter the angle: ");
            q = double.Parse(Console.ReadLine());
            result = Math.Sin(q) * Math.Sin(q) + Math.Cos(q) * Math.Cos(q);
            Console.WriteLine(result);

            /*If you want to check exactly values of sin and cos you can uncomment next part
            Console.WriteLine(sin);
            Console.WriteLine(cos);
            The question was: Why are the values not always exactly 1? Before making a programm I thought about the question and decided that the problem can be that the exactly value of sin and cos can be much more than double provide. That's why we can get not exactly 1. But I've tried a lot of times and always get exactly 1 as answer. */

            //1.2.3 Suppose that a and b are int values. Show that the expression (!(a && b) && (a || b)) || ((a && b) || !(a || b)) is true
            bool tr, a, b;
            a = true;
            b = false;
            // I didn't understand how to make this task for all cases of a and b. I mean it should made for all 4 cases: T T, T F, F T, F F but when I clean the previous values it give me error
            tr = (!(a && b) && (a || b)) || ((a && b) || !(a || b));
            Console.WriteLine(tr);

            /*1.2.10 Suppose that a variable a is declared as int a = 2147483647 (or equivalently, Integer.MAX_VALUE). What do each of the following print?
            int z = 2147483647;
            Console.WriteLine(z);
            Console.WriteLine(z+1);
            Console.WriteLine(2-z);
            Console.WriteLine(-2-z);
            Console.WriteLine(2*z);
            Console.WriteLine(4*z);
            Checked and had some fun*/

            //1.2.14 Write a program that takes two positive integers as command-line arguments and prints true if either evenly divides the other.
            int x, y;
            bool c;
            Console.WriteLine("Enter 2 numbers: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            if (x % y == 0)
            {
                c = true;
            }
            else
                c = false;
            Console.WriteLine(c);

            //1.2.15 Write a program that takes three positive integers as command-line arguments and prints true if any one of them is greater than or equal to the sum of the other two and false otherwise.
            int w, e, r;
            bool v;
            Console.WriteLine("Enter 3 numbers: ");
            w = int.Parse(Console.ReadLine());
            e = int.Parse(Console.ReadLine());
            r = int.Parse(Console.ReadLine());
            if (w >= e + r && e >= w + r && r >= w + e)
            {
                v = true;
            }
            else
                v = false;
            Console.WriteLine(v);

            //1.2.16 F = G * mass1 * mass2 / r * r >>>> F = G * mass1 * mass2 / r / r or F = G * mass1 * mass2 / (r * r)

            //1.2.18 Suppose that x and y are double values that represent the Cartesian coordinates of a point(x, y) in the plane. Give an expression whose value is the distance of the point from the origin.
            double t, u, dis;
            Console.WriteLine("Enter your coordinates: ");
            t = int.Parse(Console.ReadLine());
            u = int.Parse(Console.ReadLine());
            dis = Math.Sqrt(t * t + u * u);
            Console.WriteLine("The distance is: " + dis);

            //1.2.19 Write a program that takes two int values a and b from the command line and prints a random integer between a and b.
            int o, p, random1;
            Console.WriteLine("Enter 2 numbers: ");
            o = int.Parse(Console.ReadLine());
            p = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            random1 = rnd.Next(o, p+1);
            Console.WriteLine(random1);

            //1.2.20 Write a program that prints the sum of two random integers between 1 and 6
            int random2, random3, sum;
            Random rand = new Random();
            random2 = rand.Next(1, 7);
            random3 = rand.Next(1, 7);
            sum = random2 + random3;
            Console.WriteLine(sum);

            //1.2.21 Write a program that takes a double value t from the command line and prints the value of sin(2t) " sin(3t).
            double l, result1;
            Console.WriteLine("Enter the angle: ");
            l = double.Parse(Console.ReadLine());
            result1 = Math.Sin(2 * l) + Math.Sin(3 * l);
            Console.WriteLine(result1);

            //1.2.22 Write a program that takes three double values x0, v0, and t from the command line and prints the value of x0 + v0t + gt2 / 2, where g is the constant 9.78033.
            double k, j, h;
            Console.WriteLine("Enter x0: ");
            k = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter V0: ");
            j = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter t: ");
            h = int.Parse(Console.ReadLine());
            Console.WriteLine(k + j * h + 9.78033 * h * h / 2);

            //Until here there were easy tasks only for "Набивание руки" and learning the syntax of C# language. After 1.2.23 there are interesting and hard tasks. Please pay attention on them.

            //1.2.23 Write a program that takes two int values m and d from the command line and prints true if day d of month m is between 3 / 20 and 6 / 20, false otherwise.
            int month, day;
            bool ans;
            Console.WriteLine("Enter the month: ");
            month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the day: ");
            day = int.Parse(Console.ReadLine());
            if (month == 3)
            {
                if (day >= 20 && day <= 31)
                {
                    ans = true;
                }
                else
                    ans = false;
            }
            else if (month == 4)
            {
                if (day >= 1 && day <= 30)
                {
                    ans = true;
                }
                else
                    ans = false;
            }
            else if (month == 5)
            {
                if (day >= 1 && day <= 31)
                {
                    ans = true;
                }
                else
                    ans = false;
            }
            else if (month == 6)
            {
                if (day >= 1 && day <= 20)
                {
                    ans = true;
                }
                else
                    ans = false;
            }
            else
                ans = false;
            Console.WriteLine(ans);

            //1.2.24 Loan payments. Write a program that calculates the monthly payments you would have to make over a given number of years to pay off a loan at a given interest rate compounded continuously, taking the number of years t, the principal P, and the annual interest rate r as command - line arguments.The desired value is given by the formula Pe rt. Use Math.exp().
            int yrn, princ, rate;
            Console.Write("Enter the number of years: ");
            yrn = int.Parse(Console.ReadLine());
            Console.Write("Enter the principal: ");
            princ = int.Parse(Console.ReadLine());
            Console.Write("Enter the annual interest rate: ");
            rate = int.Parse(Console.ReadLine());
            Console.WriteLine(princ * Math.Exp(yrn * rate));

            /*1.2.25 Wind chill. Given the temperature t (in Fahrenheit) and the wind speed v
(in miles per hour), the National Weather Service defines the effective temperature
(the wind chill) to be:
w = 35.74 " 0.6215 t " (0.4275 t ! 35.75) v 0.16
Write a program that takes two double command-line arguments t and v and
prints out the wind chill. Use Math.pow(a, b) to compute ab. Note : The formula is
not valid if t is larger than 50 in absolute value or if v is larger than 120 or less than
3 (you may assume that the values you get are in that range).*/
            int temp, speed;
            Console.WriteLine("Enter the temperature: ");
            temp = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the wind speed: ");
            speed = int.Parse(Console.ReadLine());
            if (temp < 50 || speed < 120 || speed > 3)
            {
                Console.WriteLine(35.74 + 0.6215 * temp + (0.4275 * temp - 35.75) * Math.Pow(speed, 0.16));
            }
            else
                Console.WriteLine("404:Error - wrong value");

            /*1.2.26 Polar coordinates. Write a program that converts from Cartesian
            to polar coordinates.Your program should take two real numbers
           x and y on the command line and print the polar coordinates r
and &.Use the Java method Math.atan2(y, x) which computes the
arctangent value of y / x that is in the range from !# to #.*/
            double katet1, katet2, angle, hypo;
            Console.WriteLine("Enter the x coordinate: ");
            katet1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the y coordinate: ");
            katet2 = int.Parse(Console.ReadLine());
            hypo = Math.Sqrt(katet1 * katet1 + katet2 * katet2);
            angle = Math.Atan2(katet2, katet1) * 180 / Math.PI;
            Console.WriteLine(hypo);
            Console.WriteLine(angle);

            /*1.2.27 Gaussian random numbers. One way to generate a random
            number taken from the Gaussian distribution is to use the Box-Muller formula
            w = sin(2 # v) (!2 ln u)1/2
where u and v are real numbers between 0 and 1 generated by the Math.random()
            method.Write a program StdGaussian that prints out a standard Gaussian random
            variable.*/
            double gaus, g1, g2;
            Random random = new Random();
            g1 = random.NextDouble();
            g2 = random.NextDouble();
            gaus = Math.Sin(2 * Math.PI * g1) * Math.Pow(Math.Log(Math.E, g2) * (-2), 0.5);
            Console.WriteLine(gaus);

            //I don't know why, but this code outputs "не число". I can't check this because this is code from the book

            /*1.2.28 Order check. Write a program that takes three double values x, y, and z
as command-line arguments and prints true if the values are strictly ascending or
descending ( x < y < z or x > y > z ), and false otherwise.*/
            double xx, yy, zz;
            Console.WriteLine("Enter 3 numbers:");
            xx = double.Parse(Console.ReadLine());
            yy = double.Parse(Console.ReadLine());
            zz = double.Parse(Console.ReadLine());
            if (xx < yy && yy < zz)
            {
                Console.WriteLine("True");
            }
            else if (xx > yy && yy > zz)
            {
                Console.WriteLine("True");
            }
            else
                Console.WriteLine("False");


            /*1.2.29 Day of the week. Write a program that takes a date as input and prints the
day of the week that date falls on.Your program should take three command line
parameters: m(month), d(day), and y(year). For m, use 1 for January, 2 for February,
and so forth.For output, print 0 for Sunday, 1 for Monday, 2 for Tuesday, and
so forth.Use the following formulas, for the Gregorian calendar:
y0 = y !(14 !m) / 12
x = y0 " y0 /4 ! y0 /100 " y0 / 400
m0 = m " 12 $ ((14 ! m) / 12) ! 2
d0 = (d " x "(31$m0) / 12) % 7
Example: On what day of the week was February 14, 2000 ?
y0 = 2000 !1 = 1999
x = 1999 " 1999/4 ! 1999/100 " 1999 / 400 = 2483
m0 = 2 " 12$1 ! 2 = 12
d0 = (14 " 2483 "(31$12) / 12) % 7 = 2500 % 7 = 1
Answer: Monday.*/
            int dy, mon, yr, y0, m0, d0, xxx;
            Console.Write("Enter the day: ");
            dy = int.Parse(Console.ReadLine());
            Console.Write("Enter the month: ");
            mon = int.Parse(Console.ReadLine());
            Console.Write("Enter the year: ");
            yr = int.Parse(Console.ReadLine());
            y0 = yr - (14 - mon) / 12;
            xxx = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            m0 = mon + 12 * ((14 - mon) / 12) - 2;
            d0 = (dy + xxx + (31 * m0) / 12) % 7;
            Console.WriteLine(d0);

            //I don't know why, but my code and code from the book are identical but I have 0 for Sunday, 1 for Monday etc. instead of 0 for Monday, 1 for ... I think it can be because of difference between C# and Java, isn't it?

            /*1.2.30 Uniform random numbers. Write a program that prints five uniform random
values between 0 and 1, their average value, and their minimum and maximum
value. Use Math.random(), Math.min(), and Math.max().*/
            double r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11;
            Random randm = new Random();
            r1 = randm.NextDouble();
            r2 = randm.NextDouble();
            r3 = randm.NextDouble();
            r4 = randm.NextDouble();
            r5 = randm.NextDouble();
            r6 = Math.Min(r1, r2);
            r7 = Math.Min(r3, r4);
            r8 = Math.Min(r6, r7);
            r9 = Math.Max(r1, r2);
            r10 = Math.Max(r3, r4);
            r11 = Math.Max(r9, r10);
            Console.WriteLine(Math.Min(r8, r5));
            Console.WriteLine(Math.Max(r11, r5));
            Console.WriteLine((r1 + r2 + r3 + r4 + r5) / 5);

            //Math.Min / Math.Max work only for comparing 2 numbers and I don't know is my program right for 5 numbers. Please check this

            /*1.2.33 Great circle. Write a program GreatCircle that takes four command-line
arguments—x1, y1, x2, and y2—(the latitude and longitude, in degrees, of two
points on the earth) and prints out the great-circle distance between them. The
great-circle distance (in nautical miles) is given by the equation:
d = 60 arccos(sin(x1) sin(x2) " cos(x1) cos(x2) cos(y1 ! y2))
Note that this equation uses degrees, whereas Java’s trigonometric functions use
radians. Use Math.toRadians() and Math.toDegrees() to convert between the
two. Use your program to compute the great-circle distance between Paris (48.87°
N and !2.33° W) and San Francisco (37.8° N and 122.4° W).*/
            double x1, x2, y1, y2, dist;
            x1 = 48.87;
            x2 = -2.33;
            y1 = 37.8;
            y2 = 122.4;
            dist = 60 * 180 / Math.PI * Math.Acos(Math.Sin((Math.PI / 180)*x1)) * Math.Sin((Math.PI / 180)*x2) + Math.Cos((Math.PI / 180)*y1) * Math.Cos((Math.PI / 180)*y2) * Math.Cos((Math.PI / 180)*(y1 - y2));
            Console.WriteLine(dist);
            /*C# commands Math.Sin and Math.Cos work with radians that's why i need to multiply this on PI/180, or I could make another function and here call it like this:
            public double ConvertToRadians(double angle)
            {
                return (Math.PI / 180) * angle;
            }
            */
            
            //Here I get the negative result, but the distance can't be negative. I can't check this. Should I just make it positive(module)? Code is the same with Java

            /*1.2.35 Dragon curves. Write a program to print
the instructions for drawing the dragon curves of
order 0 through 5. The instructions are strings of
F, L, and R characters, where F means “draw line
while moving 1 unit forward,” L means “turn left,”
and R means “turn right.” A dragon curve of order
N is formed when you fold a strip of paper in half N
times, then unfold to right angles. The key to solving
this problem is to note that a curve of order N is a
curve of order N!1 followed by an L followed by a
curve of order N!1 traversed in reverse order, and
then to figure out a similar description for the reverse curve .*/
            string instr, F, L, R;
            double drag;
            int leng;
            F = "Draw line while moving 1 unit forward";
            L = "Turn left";
            R = "Turn right";
            Console.Write("Enter dragon curve order 0 through 5: ");
            drag = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter your instruction using F, L and R:");
            instr = Console.ReadLine();
            switch (drag)
            {
                case 0:
                    leng = 1;
                    for (int asd = 0; asd < leng; asd++)
                    {
                        if (instr[asd] == 'F')
                        {
                            Console.Write(F);
                        }
                        if (instr[asd] == 'L')
                        {
                            Console.Write(L);
                        }
                        if (instr[asd] == 'R')
                        {
                            Console.Write(R);
                        }
                        if (asd == leng - 1)
                        {
                            Console.WriteLine(".");
                        }
                        else
                            Console.Write(", ");
                    }
                    break;
                case 1:
                    leng = 3;
                    for (int asd = 0; asd < leng; asd++)
                    {
                        if (instr[asd] == 'F')
                        {
                            Console.Write(F);
                        }
                        if (instr[asd] == 'L')
                        {
                            Console.Write(L);
                        }
                        if (instr[asd] == 'R')
                        {
                            Console.Write(R);
                        }
                        if (asd == leng - 1)
                        {
                            Console.WriteLine(".");
                        }
                        else
                            Console.Write(", ");
                    }
                    break;
                case 2:
                    leng = 7;
                    for (int asd = 0; asd < leng; asd++)
                    {
                        if (instr[asd] == 'F')
                        {
                            Console.Write(F);
                        }
                        if (instr[asd] == 'L')
                        {
                            Console.Write(L);
                        }
                        if (instr[asd] == 'R')
                        {
                            Console.Write(R);
                        }
                        if (asd == leng - 1)
                        {
                            Console.WriteLine(".");
                        }
                        else
                            Console.Write(", ");
                    }
                    break;
                case 3:
                    leng = 15;
                    for (int asd = 0; asd < leng; asd++)
                    {
                        if (instr[asd] == 'F')
                        {
                            Console.Write(F);
                        }
                        if (instr[asd] == 'L')
                        {
                            Console.Write(L);
                        }
                        if (instr[asd] == 'R')
                        {
                            Console.Write(R);
                        }
                        if (asd == leng - 1)
                        {
                            Console.WriteLine(".");
                        }
                        else
                            Console.Write(", ");
                    }
                    break;
                case 4:
                    leng = 31;
                    for (int asd = 0; asd < leng; asd++)
                    {
                        if (instr[asd] == 'F')
                        {
                            Console.Write(F);
                        }
                        if (instr[asd] == 'L')
                        {
                            Console.Write(L);
                        }
                        if (instr[asd] == 'R')
                        {
                            Console.Write(R);
                        }
                        if (asd == leng - 1)
                        {
                            Console.WriteLine(".");
                        }
                        else
                            Console.Write(", ");
                    }
                    break;
                case 5:
                    leng = 63;
                    for (int asd = 0; asd < leng; asd++)
                    {
                        if (instr[asd] == 'F')
                        {
                            Console.Write(F);
                        }
                        if (instr[asd] == 'L')
                        {
                            Console.Write(L);
                        }
                        if (instr[asd] == 'R')
                        {
                            Console.Write(R);
                        }
                        if (asd == leng - 1)
                        {
                            Console.WriteLine(".");
                        }
                        else
                            Console.Write(", ");
                    }
                    break;
            }

            /*From all the tasks this one is the most incredible. Really interesting. And I tried to make it perfect working. Please enjoy))
            I think that it is so good because here many things that weren't in previous tasks such as switch.
            At the beginning I wanted to make a massive f.e. a[leng], but in this case I could input my instruction one by one (F enter R enter F ...). So now I have perfect code :)))
            However I don't like that I have to put my cycle (for ...) in every case. I made the cycle after case but the program said that there is no value for leng. That's why I put it in every one. If you will help me to fix that it will be more beautifull.*/

            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}