using System.IO;
using Tyuiu.ShmidtAA.Sprint5.Task1.V18.Lib;
namespace Tyuiu.ShmidtAA.Sprint5.Task1.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string wait = @"C:\Users\Андрей\AppData\Local\Temp\OutPutFileTask1.txt";

            string path = ds.SaveToFileTextData(-5,5);
            bool res = File.Exists(path);
            bool b_wait = true;

            Assert.AreEqual(b_wait,res);


        }
    }
}