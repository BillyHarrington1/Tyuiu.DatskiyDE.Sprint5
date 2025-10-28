using Tyuiu.DatskiyDE.Sprint5.Task6.V6.Lib;
namespace Tyuiu.DatskiyDE.Sprint5.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint5\InPutDataFileTask6V6.txt";

            int result = ds.LoadFromDataFile(path);        
            Assert.AreEqual(22, result); 
        }
    }
}