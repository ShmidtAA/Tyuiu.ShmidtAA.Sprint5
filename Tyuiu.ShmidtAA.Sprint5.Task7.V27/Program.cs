using Tyuiu.ShmidtAA.Sprint5.Task7.V27.Lib;
namespace Tyuiu.ShmidtAA.Sprint5.Task7.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds  = new DataService();

            Console.Title = "Спринт #5.7 | Выполнил: Шмидт А.А. | ИБКСб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5.7                                                             *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Шмидт Андрей Андреевич | ИБКСб-24-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл C:\\DataSprint5\\InPutDataFileTask7V27.txt                       *");
            Console.WriteLine("* (файл взять из архива согласно вашему варианту).                        *");
            Console.WriteLine("* Создать папку вручную C:\\DataSprint5\\                                    *");
            Console.WriteLine("* и скопировать в неё файл с набором символов.                            *");
            Console.WriteLine("* Удалить все пробелы, идущие подряд больше одного.                       *");
            Console.WriteLine("* Полученный результат сохранить в файл OutPutDataFileTask7V27.txt.       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V27.txt");

            Console.WriteLine(ds.LoadDataAndSave(path));
        }
    }
}
