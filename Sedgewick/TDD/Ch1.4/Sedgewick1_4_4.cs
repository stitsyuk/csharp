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
            string[] initialCollection = { "abc", "def", "ghi" };
            string[] expectedCollection = { "ghi", "def", "abc" };
            string[] actualCollection = Functions4.S1_4_4(initialCollection);
            CollectionAssert.AreEqual(expectedCollection, actualCollection);
        }
        [TestMethod]
        public void S1_4_4b()
        {
            string[] initialCollection = { "qwe", "rty", "uio" };
            string[] expectedCollection = { "uio", "rty", "qwe" };
            string[] actualCollection = Functions4.S1_4_4(initialCollection);
            CollectionAssert.AreEqual(expectedCollection, actualCollection);
        }
        [TestMethod]
        public void S1_4_4c()
        {
            string[] initialCollection = { "asd", "fgh", "jkl" };
            string[] expectedCollection = { "jkl", "fgh", "asd" };
            string[] actualCollection = Functions4.S1_4_4(initialCollection);
            CollectionAssert.AreEqual(expectedCollection, actualCollection);
        }
    }
    public static class Functions4
    {
        public static string[] S1_4_4(string[] Collection)
        {
            for (var i = 0; i < Collection.Length / 2; i++)
            {
                var temp = Collection[i];
                Collection[i] = Collection[Collection.Length - i - 1];
                Collection[Collection.Length - i - 1] = temp;
            }
            return Collection;
        }
    }
}