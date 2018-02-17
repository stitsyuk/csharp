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
98 78 76 11 22 54 88 89 24 38
The code should make a [3, 10] array from [6, 5] array*/
        [TestMethod]
        public void S1_4_12()
        {
            int[,] initialCollection = { { 99, 98, 92, 94, 99 }, { 90, 76, 92, 97, 89 }, { 85, 57, 77, 32, 34 }, { 46, 59, 66, 71, 29 }, { 98, 78, 76, 11, 22 }, { 54, 88, 89, 24, 38 } };
            int[,] expectedCollection = { { 99, 98, 92, 94, 99, 90, 76, 92, 97, 89 }, { 85, 57, 77, 32, 34, 46, 59, 66, 71, 29 }, { 98, 78, 76, 11, 22, 54, 88, 89, 24, 38 } };
            int[,] actualCollection = Functions12.S1_4_12(initialCollection);
            CollectionAssert.AreEqual(expectedCollection, actualCollection);
        }
    }
    public static class Functions12
    {
        public static int[,] S1_4_12(int[,] collection)
        {
            int[,] b = new int[3, 10];
            for (var i = 0; i < 5; i++)
            {
                b[0, i] = collection[0, i];
            }
            for (var i = 0; i < 5; i++)
            {
                b[0, i + 5] = collection[1, i];
            }
            for (var i = 0; i < 5; i++)
            {
                b[1, i] = collection[2, i];
            }
            for (var i = 0; i < 5; i++)
            {
                b[1, i + 5] = collection[3, i];
            }
            for (var i = 0; i < 5; i++)
            {
                b[2, i] = collection[4, i];
            }
            for (var i = 0; i < 5; i++)
            {
                b[2, i + 5] = collection[5, i];
            }
            return b;
        }
    }
}