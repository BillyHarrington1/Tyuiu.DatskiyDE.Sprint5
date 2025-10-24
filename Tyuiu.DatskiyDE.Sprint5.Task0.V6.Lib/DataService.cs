using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.DatskiyDE.Sprint5.Task0.V6.Lib
{
    public class DataService : ISprint5Task0V6
    {
        public string SaveToFileTextData(int x)
        {
            double dx = x;
            double y = dx / Math.Sqrt(dx * dx + dx);
            y = Math.Round(y, 3);
       
            string tempPath = Path.GetTempPath();
            string fileName = "OutPutFileTask0.txt";
            string filePath = Path.Combine(tempPath, fileName);
     
            File.WriteAllText(filePath, y.ToString());

            return filePath;
        }
    }
}