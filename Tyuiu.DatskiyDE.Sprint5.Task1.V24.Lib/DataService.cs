using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.DatskiyDE.Sprint5.Task1.V24.Lib
{
    public class DataService : ISprint5Task1V24
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
          
            string tempPath = Path.GetTempPath();
            string fileName = "OutPutFileTask1.txt";
            string filePath = Path.Combine(tempPath, fileName);      
            string fileContent = "";

            for (int x = startValue; x <= stopValue; x++)
            {
                double fx = 0.0;

                double denominator = 4.0 * x - 0.5;

                if (denominator == 0)
                {
                    fx = 0.0;
                }
                else
                {
                    fx = (3.0 * Math.Cos(x)) / denominator + Math.Sin(x) - 5.0 * x - 2.0;
                }

                fx = Math.Round(fx, 2);
                fileContent += fx.ToString() + "\n"; // каждый n в новом string
            }

            File.WriteAllText(filePath, fileContent);

            return filePath;
        }
    }
}