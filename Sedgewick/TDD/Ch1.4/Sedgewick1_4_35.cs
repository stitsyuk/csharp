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
            bool expectedAnswer = true;
            bool Answer;
            int actualValue1 = Functions35.S1_4_35(364);
            int actualValue2 = Functions35.S1_4_35(364);
            int actualValue3 = Functions35.S1_4_35(364);
            int actualValue = (actualValue1 + actualValue2 + actualValue3) / 3;
            if (actualValue < 364)
                Answer = true;
            else
                Answer = false;
            Assert.AreEqual(expectedAnswer, Answer);
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