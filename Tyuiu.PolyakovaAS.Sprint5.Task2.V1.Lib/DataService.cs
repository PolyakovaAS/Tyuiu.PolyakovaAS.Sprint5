using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.PolyakovaAS.Sprint5.Task2.V1.Lib
{
    public class DataService : ISprint5Task2V1
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            try
            {
                // Use a safe directory
                string directory = Path.GetTempPath();
                string path = Path.Combine(directory, "OutPutFileTask2.csv");

                // Delete existing file if it exists
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                // Process matrix and build CSV content
                var csvLines = new List<string>();

                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    var row = new List<string>();
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        int value = matrix[i, j];
                        // Set odd numbers to 0
                        if (value % 2 != 0)
                        {
                            value = 0;
                        }
                        row.Add(value.ToString());
                    }
                    csvLines.Add(string.Join(";", row));
                }

                // Write to file
                File.WriteAllLines(path, csvLines);

                return path;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error saving file: {ex.Message}");
            }
        }
    }
}