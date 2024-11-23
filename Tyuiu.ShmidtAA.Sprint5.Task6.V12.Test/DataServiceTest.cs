using Tyuiu.ShmidtAA.Sprint5.Task6.V12.Lib;
using System.IO;
namespace Tyuiu.ShmidtAA.Sprint5.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask6V12.txt");
        DataService ds = new DataService();
        [TestMethod]
        public void CheckPath()
        {
           
            bool res = false;
            if (File.Exists(path))
            {
                res = true;
            }
            Assert.IsTrue(res);

        }

        [TestMethod]
        public void ValidMethod()
        {
            string text = "сделанный вчера стол, купленный недавно, обиженный на всех";
            int wait = 3;
            int res = ds.LoadFromDataFile(path);

            Assert.AreEqual(wait,res);
        }
    }
}