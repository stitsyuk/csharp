using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD.Ch1._4
{
    [TestClass]
    public class Sedgewick1_4_4
    {
        /*1.4.4 Write a code fragment that reverses the order of a one-dimensional array
a[] of String values.*/
        [TestMethod]
        public void S1_4_4a()
        {
            int[] expectedCollection = { 1, 0 };
            int[] actualCollection = Functions4.S1_4_4(2);
            CollectionAssert.AreEqual(expectedCollection, actualCollection);
        }
        [TestMethod]
        public void S1_4_4b()
        {
            int[] expectedCollection = { 4, 3, 2, 1, 0 };
            int[] actualCollection = Functions4.S1_4_4(5);
            CollectionAssert.AreEqual(expectedCollection, actualCollection);
        }
        [TestMethod]
        public void S1_4_4c()
        {
            int[] expectedCollection = { 7, 6, 5, 4, 3, 2, 1, 0 };
            int[] actualCollection = Functions4.S1_4_4(8);
            CollectionAssert.AreEqual(expectedCollection, actualCollection);
        }
        [TestMethod]
        public void S1_4_4d()
        {
            int[] expectedCollection = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            int[] actualCollection = Functions4.S1_4_4(10);
            CollectionAssert.AreEqual(expectedCollection, actualCollection);
        }
    }
    public static class Functions4
    {
        public static int[] S1_4_4(int N)
        {
            int[] a = new int[N];
            for (var i = 0; i < N; i++)
                a[i] = i;
            for (var i = 0; i < N / 2; i++)
            {
                int temp = a[i];
                a[i] = a[N - i - 1];
                a[N - i - 1] = temp;
            }
            return a;
        }
    }
}