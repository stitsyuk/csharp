using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD
{
    [TestClass]
    public class DragonCurve
    {
        [TestMethod]
        public void DragonCurveTest0()
        {
            string[] expectedCollection = { "F" };
            string[] actualCollection = Functions.DragonCurve(0);
            CollectionAssert.AreEqual(expectedCollection, actualCollection);
        }
        [TestMethod]
        public void DragonCurveTest1()
        {
            string[] expectedCollection = { "FLF" };
            string[] actualCollection = Functions.DragonCurve(1);
            CollectionAssert.AreEqual(expectedCollection, actualCollection);
        }
        [TestMethod]
        public void DragonCurveTest2()
        {
            string[] expectedCollection = { "FLFLFRF" };
            string[] actualCollection = Functions.DragonCurve(2);
            CollectionAssert.AreEqual(expectedCollection, actualCollection);
        }
        [TestMethod]
        public void DragonCurveTest3()
        {
            string[] expectedCollection = { "FLFLFRFLFLFRFRF" };
            string[] actualCollection = Functions.DragonCurve(3);
            CollectionAssert.AreEqual(expectedCollection, actualCollection);
        }
        [TestMethod]
        public void DragonCurveTest4()
        {
            string[] expectedCollection = { "FLFLFRFLFLFRFRFLFLFLFRFRFLFRFRF" };
            string[] actualCollection = Functions.DragonCurve(4);
            CollectionAssert.AreEqual(expectedCollection, actualCollection);
        }
        [TestMethod]
        public void DragonCurveTest5()
        {
            string[] expectedCollection = { "FLFLFRFLFLFRFRFLFLFLFRFRFLFRFRFLFLFLFRFLFLFRFRFRFLFLFRFRFLFRFRF" };
            string[] actualCollection = Functions.DragonCurve(5);
            CollectionAssert.AreEqual(expectedCollection, actualCollection);
        }
    }

    public static class Functions
    {
        public static string[] DragonCurve(int order)
        {
            string[] curve = DragonCurvesRecursive(order);
            return curve;
        }

        public static string[] DragonCurvesRecursive(int expOrd, int curOrd = 0, string dir = "")
        {
            string newDir = "";
            string[] newDirArr = { "" };
            if (curOrd == 0) newDir = "F";
            else newDir = dir + "L" + TraverseReverseDir(dir);
            if (expOrd == curOrd)
            {
                newDirArr[0] = newDir;
                return newDirArr;
            }
            return DragonCurvesRecursive(expOrd, ++curOrd, newDir);
        }

        public static string TraverseReverseDir(string dir)
        {
            var reversedDir = "";
            var len = dir.Length;
            for (var i = len - 1; i >= 0; i--)
            {
                char c = dir[i];
                char newC;
                switch (c)
                {
                    case 'F': newC = 'F'; break;
                    case 'L': newC = 'R'; break;
                    case 'R': newC = 'L'; break;
                    default:
                        throw new Exception($"Unexpected character {c}");
                }
                reversedDir += newC;
            }
            return reversedDir;
        }
    }
}
