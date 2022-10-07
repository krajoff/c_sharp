// Напишите программу, которая на входе принимает позиции элемента в двумерном массиве
// возвращает значение этого элемента или указывает, что такого элемента нет.
Console.Clear();
Console.Write("Введите размерность двумерного массива через пробел (строк и столбцов): ");
int[] size = GetArrayFromString(Console.ReadLine());
Console.Write("Введите позицию необходимого элемента: ");
int[] position = GetArrayFromString(Console.ReadLine());
double[,] array = GetRandomTwoDimensionalArray(size, 0, 9);
DisplayTwoDimentionalArray(array);
DisplayElementArray(array, position);

int[] GetArrayFromString(string stringSize)
{
    string[] size = stringSize.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[size.Length];
    for (int i = 0; i < result.Length; i++)
        result[i] = int.Parse(size[i]);
    return result;
}

double[,] GetRandomTwoDimensionalArray(int[] size, int min, int max)
{
    double[,] array = new double[size[0], size[1]];
    for (int i = 0; i < size[0]; i++)
        for (int j = 0; j < size[1]; j++) array[i, j] = new Random().NextDouble() * (max - min) + min;
    return array;
}

void DisplayTwoDimentionalArray(double[,] array)
{
    for (int i = 0; i < size[0]; i++)
    {
        for (int j = 0; j < size[1]; j++)
            Console.Write(array[i, j].ToString("f1") + "  ");
        Console.WriteLine();
    }
}

void DisplayElementArray(double[,] array, int[] position)
{
    if (array.GetLength(0) <= position[0] && array.GetLength(1) <= position[1])
        Console.Write("Такого числа в массиве нет");
    else
    {
        Console.Write($"Позиция ({position[0]},{position[1]}) -> "
        + array[position[0], position[1]].ToString("f1"));
    }
}