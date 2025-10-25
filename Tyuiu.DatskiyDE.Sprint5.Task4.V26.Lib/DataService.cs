using System.IO;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.DatskiyDE.Sprint5.Task4.V26.Lib
{
    public class DataService : ISprint5Task4V26
    {
        public double LoadFromDataFile(string path)
        {       
            string content = File.ReadAllText(path);       
            content = content.Trim();        
            double x = double.Parse(content, CultureInfo.InvariantCulture); 
            double y = (Math.Pow(x, 3) + Math.Sin(x)) * Math.Cos(x);
            y = Math.Round(y, 3);
            return y;
        }
    }
}