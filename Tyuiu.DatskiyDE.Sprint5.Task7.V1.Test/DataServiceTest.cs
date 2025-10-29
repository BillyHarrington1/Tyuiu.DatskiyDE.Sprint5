using Tyuiu.DatskiyDE.Sprint5.Task7.V1.Lib;
namespace Tyuiu.DatskiyDE.Sprint5.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string testContent = "Привет123";
            string tempPath = Path.GetTempFileName();
            File.WriteAllText(tempPath, testContent);

            DataService ds = new DataService();
            string result = ds.LoadDataAndSave(tempPath);

            File.Delete(tempPath);

            Assert.AreEqual("Привет", result);
        }
    }
}