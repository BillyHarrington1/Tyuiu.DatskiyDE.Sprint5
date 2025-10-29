﻿using Tyuiu.DatskiyDE.Sprint5.Task7.V1.Lib;
namespace Tyuiu.DatskiyDE.Sprint5.Task7.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Дацкий Д. Е. | ИСПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнил: Дацкий Денис Евгеньевич. | ИСПб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InputDataFileTask7V1.txt                      *");
            Console.WriteLine("* Удалить все цифры из файла и сохранить результат в                      *");
            Console.WriteLine("* OutPutDataFileTask7V1.txt.                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string sourcePath = @"C:\DataSprint5\InputDataFileTask7V1.txt";

            string tempDirectory = Path.GetTempPath();
            string tempFileName = Path.GetFileName(sourcePath);
            string tempFilePath = Path.Combine(tempDirectory, tempFileName);

            File.Copy(sourcePath, tempFilePath, true);

            Console.WriteLine($"Файл скопирован в: {tempFilePath}");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string result = ds.LoadDataAndSave(tempFilePath);

            string outputPath = Path.Combine(tempDirectory, "OutPutDataFileTask7V1.txt");
            File.WriteAllText(outputPath, result);

            Console.WriteLine($"Результат сохранён в: {outputPath}");
            Console.WriteLine("Содержимое результата:");
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}