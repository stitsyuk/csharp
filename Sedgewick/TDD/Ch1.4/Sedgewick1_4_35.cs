using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD.Ch1._4
{
    [TestClass]
    public class Sedgewick1_4_35
    {
        /*1.4.35 Birthday problem. Suppose that people enter an empty room until a pair
of people share a birthday. On average, how many people will have to enter before
there is a match? Assume
birthdays to be uniform random integers between 0 and 364.*/
        [TestMethod]
        public void S1_4_35()
        {
            int expectedCollection = 0;
            int actualCollection = Functions35.S1_4_35(365);
            if (actualCollection > 1 && actualCollection < 365)
                expectedCollection = actualCollection;
            Assert.AreEqual(expectedCollection, actualCollection);
        }
    }
    public static class Functions35
    {
        public static int S1_4_35(int N)
        {
            var numb = 0;
            int[] a = new int[N + 1];
            a[0] = 0;
            for (var i = 1; i <= N; i++)
            {
                Random rnd = new Random();
                a[i] = rnd.Next(1, N + 1);
                for (var j = i - 1; j > 0; j--)
                {
                    if (a[j] == a[i])
                    {
                        goto end;
                    }
                    else
                        numb++;
                }
            }
            end:;
            return numb;
        }
    }
}