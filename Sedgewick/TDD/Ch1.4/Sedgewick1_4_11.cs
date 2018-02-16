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
            var a = 2;
            var b = 3;
            var c = 0;
            int[,] InitialArray = new int[a, b];
            for (var i = 0; i < a; i++)
            {
                for (var j = 0; j < b; j++)
                {
                    InitialArray[i, j] = c;
                    c++;
                }
            }
            int[,] expectedCollection = { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] actualCollection = Functions11.S1_4_11(InitialArray, a, b);
            CollectionAssert.AreEqual(expectedCollection, actualCollection);
        }
    }
    public static class Functions11
    {
        public static int[,] S1_4_11(int[,] Array, int a, int b)
        {
            int[,] NewArray = new int[a, b];
            for (var i = 0; i < a; i++)
            {
                for (var j = 0; j < b; j++)
                {
                    NewArray[i, j] = Array[i, j];
                }
            }
            return NewArray;
        }
    }
}