using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD.Ch1._4
{
    [TestClass]
    public class Sedgewick1_4_12
    {
        /*1.4.12 Write a code fragment to print the transposition (rows and columns
changed) of a square two-dimensional array. For the example spreadsheet array in
the text, you code would print the following:
99 98 92 94 99 90 76 92 97 89
85 57 77 32 34 46 59 66 71 29
98 78 76 11 22 54 88 89 24 38*/
        [TestMethod]
        public void S1_4_12()
        {
            int[,] expectedCollection = { { 99, 98, 92, 94, 99, 90, 76, 92, 97, 89 }, { 85, 57, 77, 32, 34, 46, 59, 66, 71, 29 }, { 98, 78, 76, 11, 22, 54, 88, 89, 24, 38 } };
            int[,] actualCollection = Functions12.S1_4_12();
            CollectionAssert.AreEqual(expectedCollection, actualCollection);
        }
    }
    public static class Functions12
    {
        public static int[,] S1_4_12()
        {
            int[,] a = { { 99, 98, 92, 94, 99 }, { 90, 76, 92, 97, 89 }, { 85, 57, 77, 32, 34 }, { 46, 59, 66, 71, 29 }, { 98, 78, 76, 11, 22 }, { 54, 88, 89, 24, 38 } };
            int[,] b = new int[3, 10];
            for (var i = 0; i < 5; i++)
            {
                b[0, i] = a[0, i];
            }
            for (var i = 0; i < 5; i++)
            {
                b[0, i + 5] = a[1, i];
            }
            for (var i = 0; i < 5; i++)
            {
                b[1, i] = a[2, i];
            }
            for (var i = 0; i < 5; i++)
            {
                b[1, i + 5] = a[3, i];
            }
            for (var i = 0; i < 5; i++)
            {
                b[2, i] = a[4, i];
            }
            for (var i = 0; i < 5; i++)
            {
                b[2, i + 5] = a[5, i];
            }
            return b;
        }
    }
}