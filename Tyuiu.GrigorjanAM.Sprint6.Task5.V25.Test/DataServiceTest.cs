using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorjanAM.Sprint6.Task5.V25.Lib;
using System.IO;

namespace Tyuiu.GrigorjanAM.Sprint6.Task5.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLFDF()
        {
            DataService ds = new DataService();
            string path = @"D:\Users\djura\source\repos\Tyuiu.GrigorjanAM.Sprint6\Tyuiu.GrigorjanAM.Sprint6.Task5.V25\bin\Debug\InPutFileTask5V25.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
