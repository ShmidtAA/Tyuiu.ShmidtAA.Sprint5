using Tyuiu.ShmidtAA.Sprint5.Task4.V20.Lib;
using System.IO;
namespace Tyuiu.ShmidtAA.Sprint5.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask4V20.txt");

            double x = 3.78;
            double wait = Math.Pow((Math.Pow(x, 2) / (Math.Sin(x))),3); 
            double res = ds.LoadFromDataFile(path);

            Assert.AreEqual(Math.Round(wait,3), res);

        }
    }
}