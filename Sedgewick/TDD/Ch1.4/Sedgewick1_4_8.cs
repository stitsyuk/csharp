using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD.Ch1._4
{
    [TestClass]
    public class Sedgewick1_4_8
    {
        /*1.4.8 What values does the following code put in the array a[]?
int N = 10;
int[] a = new int[N];
a[0] = 1;
a[1] = 1;
for (int i = 2; i < N; i++)
a[i] = a[i-1] + a[i-2];*/
        [TestMethod]
        public void S1_4_8()
        {
            int[] expectedCollection = { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };
            int[] actualCollection = Functions8.S1_4_8(10);
            CollectionAssert.AreEqual(expectedCollection, actualCollection);
        }
    }
    public static class Functions8
    {
        public static int[] S1_4_8(int N)
        {
            int[] a = new int[N];
            a[0] = 1;
            a[1] = 1;
            for (int i = 2; i < N; i++)
                a[i] = a[i - 1] + a[i - 2];
            return a;
        }
    }
}