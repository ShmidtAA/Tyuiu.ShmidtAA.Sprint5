using System.Text;
using System.IO;
using Tyuiu.ShmidtAA.Sprint5.Task3.V14.Lib;
namespace Tyuiu.ShmidtAA.Sprint5.Task3.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Шмидт А.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнил: Шмидт Андрей Андреевич | ИБКСб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение y(x) = (4x^3) / (x^3 - 1).                               *");
            Console.WriteLine("* Вычислить его значение при x = 3, результат                             *");
            Console.WriteLine("* сохранить в бинарный файл OutPutFileTask3.bin                           *");
            Console.WriteLine("* и вывести на консоль. Округлить до трёх знаков после запятой.           *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            int x = 3;
            string path = ds.SaveToFileTextData(x);


            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                double num = reader.ReadDouble();

               
               
                Console.WriteLine(num + Environment.NewLine);
                
            
            }


        }
    }
}
