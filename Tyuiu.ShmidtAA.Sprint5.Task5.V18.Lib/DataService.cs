using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.ShmidtAA.Sprint5.Task5.V18.Lib
{
    public class DataService : ISprint5Task5V18
    {
        public double LoadFromDataFile(string path)
        {
            string[] strNum = File.ReadAllLines(path);
            for (int i = 0; i < strNum.Length; i++)
            {
                strNum[i] = strNum[i].Replace('.',',');
            }

            double[] nums = Array.ConvertAll(strNum[0].Split(' '), double.Parse);

            double res = 1;
            foreach (double num in nums)
            {
                if (num >= 10 && num <= 99)
                {
                    res *= num;

                }
            }

            return Math.Round(res,3);

        }
    }
}
