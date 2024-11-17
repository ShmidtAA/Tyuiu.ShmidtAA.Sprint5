using Tyuiu.ShmidtAA.Sprint5.Task2.V18.Lib;
namespace Tyuiu.ShmidtAA.Sprint5.Task2.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,] matrix = { 
                { 3, 8, 4 }, 
                { -5, -4, -3 }, 
                { -9, 0, 2 } 
            };

            int[,] wait = {
            {1,1,1 },
            {0,0,0 },
            {0,0,1 }
            };
            DataService ds = new DataService(); 

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv"); //можно так 
            string path1 = ds.SaveToFileTextData(matrix); // и так получается

            bool b_wait = true;

            bool b_res = Path.Exists(path1);

            Assert.AreEqual(b_wait, b_res);

        }
    }
}