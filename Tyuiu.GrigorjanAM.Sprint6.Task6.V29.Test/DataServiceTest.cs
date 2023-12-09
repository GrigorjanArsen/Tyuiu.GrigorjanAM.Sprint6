﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.GrigorjanAM.Sprint6.Task6.V29.Lib;
using System.IO;

namespace Tyuiu.GrigorjanAM.Sprint6.Task6.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCTFF()
        {
            DataService ds = new DataService();
            string path = @"C:\Task6\InPutFileTask6V29.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
