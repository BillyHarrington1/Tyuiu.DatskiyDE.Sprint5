using Tyuiu.DatskiyDE.Sprint5.Task2.V1.Lib;
namespace Tyuiu.DatskiyDE.Sprint5.Task2.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Дацкий Д. Е. | ИСПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Дацкий Денис Евгеньевич. | ИСПб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элемента, заполненный         *");
            Console.WriteLine("* значениями с клавиатуры. Заменить нечётные элементы массива на 0.       *");
            Console.WriteLine("* Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль.    *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите 9 целых чисел через запятую: ");
            string input = Console.ReadLine();
            string[] numbers = input.Split(',', StringSplitOptions.RemoveEmptyEntries);

            if (numbers.Length != 9)
            {
                Console.WriteLine("Ошибка: введите ровно 9 чисел.");
                Console.ReadKey();
                return;
            }

            int[,] array = new int[3, 3];
            int index = 0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = int.Parse(numbers[index]);
                    index++;
                }
            }

            Console.WriteLine("\nИсходный массив:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(array[i, j]);
                    if (j < 2) Console.Write("; ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string filePath = ds.SaveToFileTextData(array);

            Console.WriteLine("Массив после замены нечётных на 0:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(array[i, j]);
                    if (j < 2) Console.Write("; ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nФайл сохранён по пути: {filePath}");

            Console.ReadKey();
        }
    }
}