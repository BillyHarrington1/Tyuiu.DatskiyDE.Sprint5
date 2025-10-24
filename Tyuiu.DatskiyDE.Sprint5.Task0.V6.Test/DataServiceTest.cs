using Tyuiu.DatskiyDE.Sprint5.Task0.V6.Lib;
using System.IO;

namespace Tyuiu.DatskiyDE.Sprint5.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();

            int x = 3;

            string filePath = ds.SaveToFileTextData(x);

            Assert.IsTrue(File.Exists(filePath));

            string content = File.ReadAllText(filePath);
            double result = double.Parse(content);

            Assert.AreEqual(0.866, result, 0.001);
        }
    }
}