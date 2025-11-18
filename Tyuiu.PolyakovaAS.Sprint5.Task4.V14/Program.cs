using Tyuiu.PolyakovaAS.Sprint5.Task4.V14.lib;
DataService ds = new DataService();

Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                 *");
Console.WriteLine("****************************************************************************************************");

string path = Path.Combine(new string[] { Path.GetTempPath(), "InPutDataFileTask4V14.txt" });

Console.WriteLine("Данные находятся в файле: " + path);

Console.WriteLine("****************************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                       *");
Console.WriteLine("****************************************************************************************************");

double res = ds.LoadFromDataFile(path);
Console.WriteLine(res);
Console.ReadKey();