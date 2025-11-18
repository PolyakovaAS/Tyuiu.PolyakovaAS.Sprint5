using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.PolyakovaAS.Sprint5.Task3.V19.Lib
{
    public class DataService : ISprint5Task3V19
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");



            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists) { File.Delete(path); }
            double result = Math.Round((2d * Math.Pow(x, 2d) - 1d) / (Math.Sqrt(Math.Pow(x, 2d) - 2d)), 3);


            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(result));
            }
            return path;
        }
    }
}
