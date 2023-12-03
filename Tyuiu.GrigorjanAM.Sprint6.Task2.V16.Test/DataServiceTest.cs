using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorjanAM.Sprint6.Task2.V16.Lib;

namespace Tyuiu.GrigorjanAM.Sprint6.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunc()
        {
            DataService ds = new DataService();
            int start = -1;
            int stop = 1;
            int len = stop - start + 1;
            double[] valueWaitArray;
            valueWaitArray = new double[len];

            valueWaitArray[0] = 8.35;
            valueWaitArray[1] = -0.5;
            valueWaitArray[2] = 9.63;
            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(start, stop);
            CollectionAssert.AreEqual(res, valueWaitArray);
        }
    }
}
