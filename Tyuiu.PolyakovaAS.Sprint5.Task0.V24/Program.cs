using Tyuiu.PolyakovaAS.Sprint5.Task0.V24.Lib;

DataService ds = new DataService();
int x = 3;
string path = ds.SaveToFileTextData(x);

Console.WriteLine($"* При x = {x}                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine($"Результат сохранен в файл: {path}");
Console.WriteLine("***************************************************************************");

// Выведем содержимое файла
string result = File.ReadAllText(path);
Console.WriteLine($"Содержимое файла: {result}");
Console.WriteLine("***************************************************************************");

Console.ReadKey();

