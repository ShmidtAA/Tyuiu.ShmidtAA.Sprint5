using tyuiu.cources.programming.interfaces.Sprint5;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.ShmidtAA.Sprint5.Task4.V20.Lib
{
    public class DataService : ISprint5Task4V20
    {
        public double LoadFromDataFile(string path)
        {
            double num = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string content = File.ReadAllText(path);
                content = content.Replace('.', ',');
                num = Double.Parse(content); 



            }

            double res = Math.Pow((Math.Pow(num, 2) / (Math.Sin(num))), 3);
            return   Math.Round(res,3);

        }
    }
}
