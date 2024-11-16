using Tyuiu.ShmidtAA.Sprint5.Task1.V18.Lib;
namespace Tyuiu.ShmidtAA.Sprint5.Task1.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Шмидт А.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Шмидт Андрей Андреевич | ИБКСб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция F(x) = 3x + 2 − 2(x − x / cos(x) + 1).                     *");
            Console.WriteLine("* Произвести табулирование на заданном диапазоне [-5; 5] с шагом 1.       *");
            Console.WriteLine("* При делении на ноль вернуть значение 0.                                 *");
            Console.WriteLine("* Результат сохранить в текстовый файл OutPutFileTask1.txt                *");
            Console.WriteLine("* и вывести на консоль в таблицу. Округлить до двух знаков после запятой. *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(-5, 5);

            string[] s_array = File.ReadAllLines(path);

            for (int i = 0; i < s_array.Length; i++)
            {
                Console.WriteLine(s_array[i]);
            }



        }
    }
}
