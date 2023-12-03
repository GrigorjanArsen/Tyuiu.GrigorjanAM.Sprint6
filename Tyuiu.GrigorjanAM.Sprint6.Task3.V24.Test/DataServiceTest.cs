using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorjanAM.Sprint6.Task3.V24.Lib;

namespace Tyuiu.GrigorjanAM.Sprint6.Task3.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] mx = { {1,2,3},
                          {2,2,3} };
            int[,] res = ds.Calculate(mx);
            int rows = 2;
            int col = 3;
            int[,] wait = { {1,2,3},
                            {0,0,3} };
            CollectionAssert.AreEqual(wait, res);

        }
    }
}
