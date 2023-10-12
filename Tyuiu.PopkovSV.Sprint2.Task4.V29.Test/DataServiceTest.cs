using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PopkovSV.Sprint2.Task4.V29.Lib;

namespace Tyuiu.PopkovSV.Sprint2.Task4.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 4;
            double y = 20;
            double res = ds.Calculate(x, y);
            double wait = 247.5;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 6;
            double y = 20;
            double res = ds.Calculate(x, y);
            double wait = 35.9;
            Assert.AreEqual(wait, res);
        }
    }
}
