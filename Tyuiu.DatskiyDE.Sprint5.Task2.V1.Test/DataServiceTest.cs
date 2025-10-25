using Tyuiu.DatskiyDE.Sprint5.Task2.V1.Lib;
using System.IO;
namespace Tyuiu.DatskiyDE.Sprint5.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();

            int[,] array = {
                {6, 9, 4},
                {7, 2, 4},
                {4, 8, 3}
            };

            string filePath = ds.SaveToFileTextData(array);

            Assert.IsTrue(File.Exists(filePath));

            string content = File.ReadAllText(filePath);
            string expected = "6;0;4\n0;2;4\n4;8;0";

            Assert.AreEqual(expected, content);
        }
    }
}