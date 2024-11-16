using System.Security.Cryptography;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ShmidtAA.Sprint5.Task1.V18.Lib
{
    public class DataService : ISprint5Task1V18
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(),"OutPutFileTask1.txt");
           
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            for (int i = startValue; i <= stopValue; i++)
            {
                double num = 0;
                if ((Math.Cos(i) + 1) != 0)
                {
                    num = 3 * i + 2 - (((2 * i) - i) / (Math.Cos(i) + 1));
                }
                
                num = Math.Round(num,2);

                File.AppendAllText(path,num.ToString() + Environment.NewLine);
            }
            return path;
        }
    }
}
