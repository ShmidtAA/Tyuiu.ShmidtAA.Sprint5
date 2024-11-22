using Tyuiu.ShmidtAA.Sprint5.Task5.V18.Lib;
using System.IO;
namespace Tyuiu.ShmidtAA.Sprint5.Task5.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V18.txt");
            DataService ds = new DataService();
            double[] numbers = { 13.93, 7, -8, 2, 8, -6.61, 19, 11.88, -5, 1, 12.33, 2.71, 5, 5.66, -7, 14, -1.27, -2.49, 7.23, 3 };

            double wait = 1;
            foreach (double num in numbers)
            {
                if (num >= 10 && num <= 99)
                {
                    wait *= num;

                }

            }

            double res = ds.LoadFromDataFile(path);

            Assert.AreEqual(Math.Round(wait,3), res);

        }
    }
}