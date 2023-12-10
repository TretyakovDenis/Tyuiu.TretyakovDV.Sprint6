using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TretyakovDV.Sprint6.Task5.V15.Lib;


namespace Tyuiu.TretyakovDV.Sprint6.Task5.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();
            var path = @"C:\Users\Денис\source\repos\Tyuiu.TretyakovDV.Sprint6\Tyuiu.TretyakovDV.Sprint6.Task5.V15\bin\Debug\InPutFileTask5V15.txt";
            var res = ds.LoadFromDataFile(path);
            double[] wait = { 3.36, 4.13 };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}