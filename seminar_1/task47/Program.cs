// Задайте двумерный массив размером mхn, заполненный случайными вещественными числами
// m = 3, n = 4. 0.5 7 -2 -.2 ... 1 -3.3 8 -9.9 ... 8 7.8 -7.1 9
Console.Clear();
Console.Write("Введите размерность двумерного массива через пробел (строк и столбцов): ");
int[] size = GetSizeArrayFromString(Console.ReadLine());
double[,] array = GetRandomTwoDimensionalArray(size, 0, 9);
DisplayTwoDimentionalArray(array);

int[] GetSizeArrayFromString(string stringSize)
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