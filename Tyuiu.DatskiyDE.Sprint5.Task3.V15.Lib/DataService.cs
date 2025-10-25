using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.DatskiyDE.Sprint5.Task3.V15.Lib
{
    public class DataService : ISprint5Task3V15
    {
        public string SaveToFileTextData(int x)
        {
            double dx = x;
            double y = -1.4 * Math.Pow(dx, 3) + 2.3 * Math.Pow(dx, 2) + 0.6 * dx;
            y = Math.Round(y, 3);
    
            string tempPath = Path.GetTempPath();
            string fileName = "OutPutFileTask3.bin";
            string filePath = Path.Combine(tempPath, fileName);
          
            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                writer.Write(y);
            }

            return filePath;
        }
    }
}