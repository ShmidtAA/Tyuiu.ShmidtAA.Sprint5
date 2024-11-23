using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.ShmidtAA.Sprint5.Task6.V12.Lib
{
    public class DataService : ISprint5Task6V12
    {
        public int LoadFromDataFile(string path)
        {
           
           int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string text = reader.ReadToEnd();

                try
                {
                    for (int i = 0; i < text.Length; i++)
                    {
                        if (text[i] == 'н' && text[i + 1] == 'н')
                        {
                            count++;

                        }

                    }
                }
                catch(ArgumentException ex) 
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                   

            }
            return count;

        }
    }
}
