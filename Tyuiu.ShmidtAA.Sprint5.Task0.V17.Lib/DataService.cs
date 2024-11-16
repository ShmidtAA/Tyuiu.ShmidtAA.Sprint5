﻿
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5; 
namespace Tyuiu.ShmidtAA.Sprint5.Task0.V17.Lib
{
    public class DataService : ISprint5Task0V17
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";

            double res = Math.Pow(2.4 *x, 3) + Math.Pow(0.4 * x,2) - 1.4 * x + 4.1;

            res = Math.Round(res,3);

            File.WriteAllText(path,Convert.ToString(res));
            
            return path;

        }
    }
}
