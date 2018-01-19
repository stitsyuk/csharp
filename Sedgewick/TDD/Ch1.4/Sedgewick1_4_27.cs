using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD.Ch1._4
{
    [TestClass]
    public class Sedgewick1_4_27
    {
        /*1.4.27 Rumors. Alice is throwing a party with N other guests, including Bob. Bob
starts a rumor about Alice by telling it to one of the other guests. A person hearing
this rumor for the first time will immediately tell it to one other guest, chosen at
random from all the people at the party except Alice and the person from whom
they heard it. If a person (including Bob) hears the rumor for a second time, he or
she will not propagate it further. Write a program to estimate the probability that
everyone at the party (except Alice) will hear the rumor before it stops propagating.*/
        [TestMethod]
        public void S1_4_27a()
        {
            int expectedCollection = 0;
            int actualCollection = Functions27.S1_4_27(10);
            if (actualCollection > 1 && actualCollection < 10)
                expectedCollection = actualCollection;
            Assert.AreEqual(expectedCollection, actualCollection);
        }
        [TestMethod]
        public void S1_4_27b()
        {
            int expectedCollection = 0;
            int actualCollection = Functions27.S1_4_27(50);
            if (actualCollection > 1 && actualCollection < 50)
                expectedCollection = actualCollection;
            Assert.AreEqual(expectedCollection, actualCollection);
        }
        [TestMethod]
        public void S1_4_27c()
        {
            int expectedCollection = 0;
            int actualCollection = Functions27.S1_4_27(100);
            if (actualCollection > 1 && actualCollection < 100)
                expectedCollection = actualCollection;
            Assert.AreEqual(expectedCollection, actualCollection);
        }
    }
    public static class Functions27
    {
        public static int S1_4_27(int N)
        {
            var numb = 0;
            int[] a = new int[N + 1];
            a[0] = 0;  //This is Alice
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
