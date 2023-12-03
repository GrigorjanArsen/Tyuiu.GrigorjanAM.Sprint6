using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorjanAM.Sprint6.Task0.V26.Lib;

namespace Tyuiu.GrigorjanAM.Sprint6.Task0.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2;
            double res = ds.Calculate(x);
            double wait = 0.5;
            Assert.AreEqual(wait, res);

        }
    }
}
