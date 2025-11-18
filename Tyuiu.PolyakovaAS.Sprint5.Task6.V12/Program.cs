using Tyuiu.PolyakovaAS.Sprint5.Task6.V12.Lib;

DataService ds = new DataService();
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask6V12.txt";

Console.WriteLine("Данные находятся в файле: " + path);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

double res = ds.LoadFromDataFile(path);

Console.WriteLine("Количество удвоенных букв нн в заданной строке = " + res);
Console.ReadKey();