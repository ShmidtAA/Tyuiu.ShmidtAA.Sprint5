using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ShmidtAA.Sprint5.Task2.V18.Lib
{
    public class DataService : ISprint5Task2V18
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.GetUpperBound(1) + 1;

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");
            
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {

                    if(matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1;
                    }else if (matrix[i, j] < 0)
                    {
                        matrix[i,j] = 0;
                    }


                    File.AppendAllText(path, matrix[i,j].ToString());
                    if (j < cols - 1 )
                    {
                        File.AppendAllText(path, ";");
                    }
                    else if (i < rows -1)
                    {
                        File.AppendAllText(path, Environment.NewLine);
                    }


                }

            }
            return path;

        }
    }
}
