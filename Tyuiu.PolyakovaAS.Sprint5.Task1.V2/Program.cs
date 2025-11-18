using Tyuiu.PolyakovaAS.Sprint5.Task1.V2.Lib;
DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать консольную программу на C#, которая вычисляет результат по     *");
Console.WriteLine("* формуле и записывает его в файл                                         *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("* Исходные данные: Интервал от -5 до 5                                    *");
string res = ds.SaveToFileTextData(-5, 5);
Console.WriteLine("* Результат:                                                              *");
string[] r = File.ReadAllLines(res);
int k = -6;
Console.WriteLine("---------------");
foreach (string s in r)
{

    Console.WriteLine("| {0, -6:f2} | {1, 4:d}", s, k++ + " |");
}
Console.WriteLine("---------------");