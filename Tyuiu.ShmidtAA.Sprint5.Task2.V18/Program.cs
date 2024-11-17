using Tyuiu.ShmidtAA.Sprint5.Task2.V18.Lib;

namespace Tyuiu.ShmidtAA.Sprint5.Task2.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Шмидт А.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Шмидт Андрей Андреевич | ИБКСб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры.                                                *");
            Console.WriteLine("* Заменить положительные элементы массива на 1, отрицательные на 0.       *");
            Console.WriteLine("* Результат сохранить в файл OutPutFileTask2.csv                          *");
            Console.WriteLine("* и вывести на консоль.                                                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");



            DataService ds = new DataService();

            int[,] matrix = new int[3, 3];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("Введите {0} строку матрицы через пробел: ", i + 1);
                string[] input = Console.ReadLine().Split(" ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Convert.ToInt32(input[j]);
                }
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.SaveToFileTextData(matrix));

      


        }
    }
}
