using Tyuiu.DatskiyDE.Sprint5.Task1.V24.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Tyuiu.DatskiyDE.Sprint5.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            string filePath = ds.SaveToFileTextData(startValue, stopValue);

            Assert.IsTrue(File.Exists(filePath));

            string content = File.ReadAllText(filePath);
            string[] lines = content.Split('\n', StringSplitOptions.RemoveEmptyEntries);

            Assert.AreEqual(11, lines.Length);    
            double firstValue = double.Parse(lines[0]);
            Assert.AreEqual(23.92, firstValue, 0.01); 
        }
    }
}