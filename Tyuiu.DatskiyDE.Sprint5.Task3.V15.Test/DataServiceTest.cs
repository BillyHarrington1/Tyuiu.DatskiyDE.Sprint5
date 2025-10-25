using Tyuiu.DatskiyDE.Sprint5.Task3.V15.Lib;
using System.IO;

namespace Tyuiu.DatskiyDE.Sprint5.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();

            int x = 5;

            string filePath = ds.SaveToFileTextData(x);

            Assert.IsTrue(File.Exists(filePath));

           
            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                double result = reader.ReadDouble();
                Assert.AreEqual(-114.5, result, 0.001);                 
            }
        }
    }
}