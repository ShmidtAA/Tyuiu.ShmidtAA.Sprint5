using Tyuiu.ShmidtAA.Sprint5.Task4.V20.Lib;
using System.IO;
namespace Tyuiu.ShmidtAA.Sprint5.Task4.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
           DataService ds = new DataService();

            Console.Title = "Спринт #5.4 | Выполнил: Шмидт А.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5.4                                                             *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #20                                                             *");
            Console.WriteLine("* Выполнил: Шмидт Андрей Андреевич | ИБКСб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask4V0.txt                        *");
            Console.WriteLine("* (файл взять из архива согласно вашему варианту).                        *");
            Console.WriteLine("* Создать папку вручную C:\\DataSprint5\\                                    *");
            Console.WriteLine("* и скопировать в неё файл с вещественным значением.                      *");
            Console.WriteLine("* Прочитать значение из файла и подставить вместо X в формуле             *");
            Console.WriteLine("* y = ((x² / sin(x))³).                                                   *");
            Console.WriteLine("* Вычислить значение по формуле (полученное значение округлить            *");
            Console.WriteLine("* до трёх знаков после запятой)                                           *");
            Console.WriteLine("* и вернуть полученный результат на консоль.                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask4V20.txt");
            Console.WriteLine(ds.LoadFromDataFile(path));
        }
    }
}
