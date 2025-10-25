using Tyuiu.DatskiyDE.Sprint5.Task4.V26.Lib;
namespace Tyuiu.DatskiyDE.Sprint5.Task4.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint5\InPutDataFileTask4V26.txt";
            double result = ds.LoadFromDataFile(path);           
            Assert.AreEqual(52.842, result, 0.001); 
        }
    }
}