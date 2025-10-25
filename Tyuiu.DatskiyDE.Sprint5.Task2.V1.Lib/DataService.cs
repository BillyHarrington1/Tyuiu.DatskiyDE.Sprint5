using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.DatskiyDE.Sprint5.Task2.V1.Lib
{
    public class DataService : ISprint5Task2V1
    {
        public string SaveToFileTextData(int[,] array)
        {
           
            string tempPath = Path.GetTempPath();
            string fileName = "OutPutFileTask2.csv";
            string filePath = Path.Combine(tempPath, fileName);
           
            string fileContent = "";

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (array[i, j] % 2 != 0) 
                        array[i, j] = 0;

                    fileContent += array[i, j];
                    if (j < 2) fileContent += ";"; // разделение столба
                }
                if (i < 2) fileContent += "\n"; // разделение строки
            }

            File.WriteAllText(filePath, fileContent);

            return filePath;
        }
    }
}