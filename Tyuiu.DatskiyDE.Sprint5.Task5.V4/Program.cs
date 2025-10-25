using Tyuiu.DatskiyDE.Sprint5.Task5.V4.Lib;
namespace Tyuiu.DatskiyDE.Sprint5.Task5.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Дацкий Д. Е. | ИСПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Дацкий Денис Евгеньевич. | ИСПб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:DataSprint5InPutDataFileTask5V4.txt                          *");
            Console.WriteLine("* Найти произведение всех вещественных чисел в файле.                     *");
            Console.WriteLine("* Полученный результат вывести на консоль. Округлить до трёх знаков.      *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V4.txt";

            Console.WriteLine("Файл для чтения: " + path);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double result = ds.LoadFromDataFile(path);
            Console.WriteLine($"Результат: {result:F3}");

            Console.ReadKey();
        }
    }
}