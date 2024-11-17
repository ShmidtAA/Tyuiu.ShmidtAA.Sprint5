using Tyuiu.ShmidtAA.Sprint5.Task3.V14.Lib;
namespace Tyuiu.ShmidtAA.Sprint5.Task3.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            string path = ds.SaveToFileTextData(x);

            bool res = File.Exists(path);

            Assert.IsTrue(res);

        }
    }
}