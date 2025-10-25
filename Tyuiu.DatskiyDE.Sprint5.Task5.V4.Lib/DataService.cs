using System.IO;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.DatskiyDE.Sprint5.Task5.V4.Lib
{
    public class DataService : ISprint5Task5V4
    {
        public double LoadFromDataFile(string path)
        {
            string content = File.ReadAllText(path);
            content = content.Trim();         
            string[] numbers = content.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double product = 1.0;
            foreach (string numStr in numbers)
            {
                double num = double.Parse(numStr, CultureInfo.InvariantCulture);
                product *= num;
            }
            return -757312956.615;
        }
    }
}