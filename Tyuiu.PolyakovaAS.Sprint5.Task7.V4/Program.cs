using Tyuiu.PolyakovaAS.Sprint5.Task7.V4.Lib;

DataService ds = new DataService();

Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
string path = @"C:\Users\User\AppData\Local\Temp\InPutDataFileTask7V4.txt";
string res = ds.LoadDataAndSave(path);
Console.WriteLine("Результат: " + res);
Console.ReadLine();