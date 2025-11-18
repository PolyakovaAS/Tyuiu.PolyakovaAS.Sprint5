using Tyuiu.PolyakovaAS.Sprint5.Task5.V4.Lib;
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
Console.WriteLine("**************************************************************************");
DataService ds = new DataService();
string path = @"C:\Users\User\source\repos\Tyuiu.Polyakova.Sprint5\DataSprint5\InPutDataFileTask5V4.txt";
Console.WriteLine($"Данные находятся в файле: {path}");

Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

double res = ds.LoadFromDataFile(path);
Console.WriteLine($"Сумма чётных элементов файла = {res}");
Console.ReadKey();

