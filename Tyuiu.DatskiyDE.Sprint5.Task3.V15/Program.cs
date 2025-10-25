using Tyuiu.DatskiyDE.Sprint5.Task3.V15.Lib;
namespace Tyuiu.DatskiyDE.Sprint5.Task3.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Дацкий Д. Е. | ИСПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Дацкий Денис Евгеньевич. | ИСПб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение: F(x) = -1.4x^3 + 2.3x^2 + 0.6x                          *");
            Console.WriteLine("* Вычислить его значение при x=5, результат сохранить в бинарный файл     *");
            Console.WriteLine("* OutPutFileTask3.bin и вывести на консоль. Округлить до трёх знаков.     *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 5;

            Console.WriteLine("x = " + x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string filePath = ds.SaveToFileTextData(x);
    
            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                double result = reader.ReadDouble();
                Console.WriteLine($"Результат: {result:F3}");
            }

            Console.WriteLine($"Файл сохранён по пути: {filePath}");

            Console.ReadKey();
        }
    }
}