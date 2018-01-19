using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD.Ch1._4
{
    [TestClass]
    public class Sedgewick1_4_16
    {
        /*1.4.16 Modify the spreadsheet code fragment in the text to compute a weighted
average of the rows, where the weights of each test score are in a one-dimensional
array weights[]. For example, to assign the last of the three tests in our example to
be twice the weight of the others, you would use
double[] weights = { .25, .25, .50 };
Note that the weights should sum to 1.*/
        [TestMethod]
        public void S1_4_16()
        {
            double expectedCollection = 0.25;
            double actualCollection = Functions16.S1_4_16(4);
            Assert.AreEqual(expectedCollection, actualCollection);
        }
    }
    public static class Functions16
    {
        public static double S1_4_16(int N)
        {
            var sum = 0.0;
            double[] a = new double[N];
            for (var i = 0; i < N; i++)
            {
                a[i] = 0.25;
                sum += a[i];
            }
            return sum/N;
        }
    }
}