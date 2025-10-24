using Tyuiu.DatskiyDE.Sprint5.Task1.V24.Lib;
namespace Tyuiu.DatskiyDE.Sprint5.Task1.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Дацкий Д. Е. | ИСПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Дацкий Денис Евгеньевич. | ИСПб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение: F(x) = (3*cos(x))/(4x-0.5) + sin(x) - 5x - 2            *");
            Console.WriteLine("* Произвести табулирование на диапазоне [-5, 5] с шагом 1.                *");
            Console.WriteLine("* При делении на ноль — вернуть 0. Результат сохранить в файл             *");
            Console.WriteLine("* OutPutFileTask1.txt и вывести на консоль в таблице.                     *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Начало диапазона: " + startValue);
            Console.WriteLine("Конец диапазона: " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string filePath = ds.SaveToFileTextData(startValue, stopValue);

       
            string content = File.ReadAllText(filePath);
            string[] values = content.Split('\n', StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("+-------+--------+");
            Console.WriteLine("|   x   |  f(x)  |");
            Console.WriteLine("+-------+--------+");

            for (int i = 0; i < values.Length; i++)
            {
                int x = startValue + i;
                Console.WriteLine($"|  {x,3}  | {values[i],6} |");
            }

            Console.WriteLine("+--------+--------+");
            Console.WriteLine($"Файл сохранён по пути: {filePath}");

            Console.ReadKey();
        }
    }
}