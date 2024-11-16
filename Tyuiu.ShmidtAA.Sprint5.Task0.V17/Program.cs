using Tyuiu.ShmidtAA.Sprint5.Task0.V17.Lib;
namespace Tyuiu.ShmidtAA.Sprint5.Task0.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Спринт #5 | Выполнил: Шмидт А.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Шмидт Андрей Андреевич | ИБКСб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение F(x) = 2.4x³ + 0.4x² − 1.4x + 4.1.                       *");
            Console.WriteLine("* Вычислить его значение при x = 3, результат                             *");
            Console.WriteLine("* сохранить в текстовый файл OutPutFileTask0.txt                          *");
            Console.WriteLine("* и вывести на консоль. Округлить до трёх знаков после запятой.           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            DataService ds = new DataService();

            int x = 3;
            string res =  ds.SaveToFileTextData(x);


            Console.WriteLine($"файл создан {res}");

        }
    }
}
