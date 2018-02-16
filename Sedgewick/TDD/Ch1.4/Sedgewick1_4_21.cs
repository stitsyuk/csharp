using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD.Ch1._4
{
    [TestClass]
    public class Sedgewick1_4_21
    {
        /*1.4.21 Longest plateau. Given an array of integers, find the length and location of
the longest contiguous sequence of equal values.

 I didn't understand the task so I googled, after an example it became clear:
 For example, if the command line arguments are “1 2 2 2 2 5 5 5 3” your program should output the numbers 1 4 
 (the first number is a zero-based offset, and the second number is the length of the subsequence). 
 If a contiguous subsequence appears at the beginning or end of the array, treat this as a special case;
 e.g.,for input “5 5 5 5 3 8 8 8 1”your output should be 0 4 (and not 5 3).*/
        [TestMethod]
        public void S1_4_21a()
        {
            int[] initialCollection = { 1, 2, 2, 2, 2, 5, 5, 5, 3 };
            int[] expectedCollection = { 1, 4 };
            int[] actualCollection = Functions21.S1_4_21a(initialCollection);
            CollectionAssert.AreEqual(expectedCollection, actualCollection);
        }
        [TestMethod]
        public void S1_4_21b()
        {
            int[] initialCollection = { 5, 5, 5, 5, 3, 8, 8, 8, 1 };
            int[] expectedCollection = { 0, 4 };
            int[] actualCollection = Functions21.S1_4_21a(initialCollection);
            CollectionAssert.AreEqual(expectedCollection, actualCollection);
        }
    }
    public static class Functions21
    {
        public static int[] S1_4_21a(int[] Array)
        {
            var pos = 0;
            var lng = 1;
            var c = 0;
            var d = 0;
            for (var i = 1; i < 9; i++)
            {
                if (Array[i] == Array[i-1])
                {
                    lng++;
                }
                else
                {
                    if (lng > c)
                    {
                        c = lng;
                        lng = 1;
                        d = pos;
                    }
                    pos = i;
                }
            }
            int[] newArray = { d, c };
            return newArray;
        }
    }
}
