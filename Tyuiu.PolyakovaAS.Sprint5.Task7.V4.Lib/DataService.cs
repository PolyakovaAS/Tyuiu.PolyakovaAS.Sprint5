using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PolyakovaAS.Sprint5.Task7.V4.Lib
{
    public class DataService : ISprint5Task7V4
    {
        public string LoadDataAndSave(string path)
        {
            string pathTransfer = File.ReadAllText(path); 
            string stringValues = pathTransfer; 

            string result = "";

            foreach (char c in stringValues)
            {
                
                if ((c >= 'А' && c <= 'Я') || (c >= 'а' && c <= 'я'))
                {
                    
                    result += '#';
                }
                else
                {
                    
                    result += c;
                }
            }
            string outputFile = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V4.txt");
            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                writer.WriteLine(result);
            }
            return outputFile;
        }
    }
}