using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD
{
    [TestClass]
    public class SortArrOfDig
    {
        [TestMethod]
        public void SortArrOfDigTest1()
        {
            int[] initialCollection = { 2, 4, 6, 3, 5, 1, 8, 15 };
            int[] expectedCollection = { 1, 2, 3, 4, 5, 6, 8, 15 };
            int[] actualCollection = SortingFunc1.sorting(initialCollection);
            CollectionAssert.AreEqual(expectedCollection, actualCollection);
        }
        [TestMethod]
        public void SortArrOfDigTest2()
        {
            int[] initialCollection = { 7, 4, 8, 12, 46, 2, 1, 9, 3, 16 };
            int[] expectedCollection = { 1, 2, 3, 4, 7, 8, 9, 12, 16, 46 };
            int[] actualCollection = SortingFunc1.sorting(initialCollection);
            CollectionAssert.AreEqual(expectedCollection, actualCollection);
        }
        [TestMethod]
        public void SortArrOfDigTest3()
        {
            int[] initialCollection = { 11, 1, 34, 14, 75, 24, 35, 23, 67, 100 };
            int[] expectedCollection = { 1, 11, 14, 23, 24, 34, 35, 67, 75, 100 };
            int[] actualCollection = SortingFunc1.sorting(initialCollection);
            CollectionAssert.AreEqual(expectedCollection, actualCollection);
        }
    }

    public static class SortingFunc1
    {
        public static int[] sorting(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (isBigger(A[j], A[j - 1]) == true)
                    {
                        int temp = A[j - 1];
                        A[j - 1] = A[j];
                        A[j] = temp;
                    }
                }
            }
            return A;
        }

        static bool isBigger(int current, int previous)
        {
            if (current < previous)
                return true;
            else
                return false;
        }
    }
}
