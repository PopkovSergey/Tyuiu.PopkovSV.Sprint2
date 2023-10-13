using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PopkovSV.Sprint2.Task6.V9.Lib;

namespace Tyuiu.PopkovSV.Sprint2.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();

            Assert.AreEqual(14.10, ds.FindDateOfNextDay(13,10));

            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfNextDay(-1, -1);
            });
            Assert.ThrowsException<ArgumentException>(() =>
            {
                ds.FindDateOfNextDay(32, 13);
            });
        }
    }
}