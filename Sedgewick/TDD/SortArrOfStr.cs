using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD
{
    [TestClass]
    public class SortArrOfStr
    {
        [TestMethod]
        public void SortArrOfStrTest1()
        {
            string initialString = "jihgfedcba";
            string expectedString = "abcdefghij";
            string actualString = SortingFunc2.sorting(initialString);
            Assert.AreEqual(expectedString, actualString);
        }
        [TestMethod]
        public void SortArrOfStrTest2()
        {
            string initialString = "abcdfgehij";
            string expectedString = "abcdefghij";
            string actualString = SortingFunc2.sorting(initialString);
            Assert.AreEqual(expectedString, actualString);
        }
        [TestMethod]
        public void SortArrOfStrTest3()
        {
            string initialString = "bjehidcafg";
            string expectedString = "abcdefghij";
            string actualString = SortingFunc2.sorting(initialString);
            Assert.AreEqual(expectedString, actualString);
        }
    }

    public static class SortingFunc2
    {
        public static string sorting(string chars)
        {
            char[] A = chars.ToCharArray();
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    if (isBigger(A[j], A[j - 1]) == true)
                    {
                        char temp = A[j - 1];
                        A[j - 1] = A[j];
                        A[j] = temp;
                    }
                }
            }
            string newChars = string.Join("", A);
            return newChars;
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
