using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TretyakovDV.Sprint4.Task0.V18.Lib;
namespace Tyuiu.TretyakovDV.Sprint4.Task0.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(1);
            double wait = -3.5;
            Assert.AreEqual(res, wait);
        }
    }
}