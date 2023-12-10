using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TretyakovDV.Sprint6.Task6.V22.Lib;
using System.IO;
namespace Tyuiu.TretyakovDV.Sprint6.Task6.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();
            var path = @"C:\Users\Денис\source\repos\Tyuiu.TretyakovDV.Sprint6\Tyuiu.TretyakovDV.Sprint6.Task6.V22\bin\Debug\InPutFileTask6V22.txt";
            var res = ds.CollectTextFromFile(path);
            string wait = "MLgyapd kEPQzl IOuDWll TMRyztkPxzEVkcarVMlQ unwTmf";
            Assert.AreEqual(wait, res);
        }
    }
}