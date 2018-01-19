using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD.Ch1._4
{
    [TestClass]
    public class Sedgewick1_4_11
    {
        /*1.4.11 Write code fragments to create a two-dimensional array b[][] that is a
copy of an existing two-dimensional array a[][]*/
        [TestMethod]
        public void S1_4_11()
        {
            int[,] expectedCollection = { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] actualCollection = Functions11.S1_4_11();
            CollectionAssert.AreEqual(expectedCollection, actualCollection);
        }
    }
    public static class Functions11
    {
        public static int[,] S1_4_11()
        {
            int[,] a = { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] b = new int[2, 3];
            for (var i = 0; i < 2; i++)
            {
                for (var j = 0; j < 3; j++)
                {
                    b[i, j] = a[i, j];
                }
            }
            return b;
        }
    }
}