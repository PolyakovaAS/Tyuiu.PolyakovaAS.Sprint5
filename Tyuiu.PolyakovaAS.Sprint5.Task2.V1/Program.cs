using Tyuiu.PolyakovaAS.Sprint5.Task2.V1.Lib;
DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int[,] matrix = new int[3, 3];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"Элемент массива [{i + 1},{j + 1}]: ");
        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine();

Console.WriteLine("Массив: ");

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]}\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string res = ds.SaveToFileTextData(matrix);

Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] % 2 != 0)
        {
            matrix[i, j] = 0;
        }

    }
}
Console.WriteLine();

Console.WriteLine("Измененный массив: ");

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]}\t");
    }
    Console.WriteLine();
}

Console.ReadLine();

