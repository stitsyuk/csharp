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
            var expectedCollection = "F";
            var actualCollection = Functions.DragonCurve(0);
            Assert.AreEqual(expectedCollection, actualCollection);
        }
        [TestMethod]
        public void DragonCurveTest1()
        {
            var expectedCollection = "FLF";
            var actualCollection = Functions.DragonCurve(1);
            Assert.AreEqual(expectedCollection, actualCollection);
        }
        [TestMethod]
        public void DragonCurveTest2()
        {
            var expectedCollection = "FLFLFRF";
            var actualCollection = Functions.DragonCurve(2);
            Assert.AreEqual(expectedCollection, actualCollection);
        }
        [TestMethod]
        public void DragonCurveTest3()
        {
            var expectedCollection = "FLFLFRFLFLFRFRF";
            var actualCollection = Functions.DragonCurve(3);
            Assert.AreEqual(expectedCollection, actualCollection);
        }
        [TestMethod]
        public void DragonCurveTest4()
        {
            var expectedCollection = "FLFLFRFLFLFRFRFLFLFLFRFRFLFRFRF";
            var actualCollection = Functions.DragonCurve(4);
            Assert.AreEqual(expectedCollection, actualCollection);
        }
        [TestMethod]
        public void DragonCurveTest5()
        {
            var expectedCollection = "FLFLFRFLFLFRFRFLFLFLFRFRFLFRFRFLFLFLFRFLFLFRFRFRFLFLFRFRFLFRFRF";
            var actualCollection = Functions.DragonCurve(5);
            Assert.AreEqual(expectedCollection, actualCollection);
        }
    }

    public static class Functions
    {
        public static string DragonCurve(int order)
        {
            var curve = DragonCurvesRecursive(order);
            return curve;
        }

        public static string DragonCurvesRecursive(int expOrd, int curOrd = 0, string dir = "")
        {
            string newDir;
            if (curOrd == 0) newDir = "F";
            else newDir = dir + "L" + TraverseReverseDir(dir);
            if (expOrd == curOrd) return newDir;
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
