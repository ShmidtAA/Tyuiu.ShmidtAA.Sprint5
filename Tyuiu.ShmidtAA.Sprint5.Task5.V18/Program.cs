using Tyuiu.ShmidtAA.Sprint5.Task5.V18.Lib;
namespace Tyuiu.ShmidtAA.Sprint5.Task5.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #5.5 | Выполнил: Шмидт А.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5.5                                                             *");
            Console.WriteLine("* Тема: Чтение набора данных из текстового файла                          *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Шмидт Андрей Андреевич | ИБКСб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask5V18.txt                       *");
            Console.WriteLine("* (файл взять из архива согласно вашему варианту).                        *");
            Console.WriteLine("* Создать папку вручную C:\\DataSprint5\\                                    *");
            Console.WriteLine("* и скопировать в неё файл с набором значений.                            *");
            Console.WriteLine("* Найти произведение всех двузначных чисел в файле.                       *");
            Console.WriteLine("* Полученный результат вывести на консоль.                                *");
            Console.WriteLine("* У вещественных значений округлить до трёх знаков после запятой.         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V18.txt");

            Console.WriteLine(ds.LoadFromDataFile(path));
        }
    }
}
