// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// 1 4 7 2 ... 5 9 2 3 ... 8 4 2 4 Среднее арифметическое элементов в каждом столбце 4.6; 5.6; 3.6; 3
Console.Clear();
Console.Write("Введите размерность двумерного массива через пробел (строк и столбцов): ");
int[] size = GetArrayFromString(Console.ReadLine());
int[,] array = GetRandomTwoDimensionalArray(size, 0, 9);
DisplayTwoDimentionalArray(array);
AverageValueColumn(array, size);

int[] GetArrayFromString(string stringSize)
{
    string[] size = stringSize.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[size.Length];
    for (int i = 0; i < result.Length; i++)
        result[i] = int.Parse(size[i]);
    return result;
}

int[,] GetRandomTwoDimensionalArray(int[] size, int min, int max)
{
    int[,] array = new int[size[0], size[1]];
    for (int i = 0; i < size[0]; i++)
        for (int j = 0; j < size[1]; j++) array[i, j] = new Random().Next(min, max);
    return array;
}

void DisplayTwoDimentionalArray(int[,] array)
{
    for (int i = 0; i < size[0]; i++)
    {
        for (int j = 0; j < size[1]; j++)
            Console.Write(array[i, j] + "  ");
        Console.WriteLine();
    }
}

void AverageValueColumn(int[,] array, int[] size)
{
    double[] average = new double[size[1]];
    Console.Write("Среднее арифметическое элементов в каждом столбце: ");
    for (int j = 0; j < size[1]; j++)
    {
        int sum = 0;
        for (int i = 0; i < size[0]; i++) 
            sum = sum + array[i, j];
        average[j] = sum/(double)size[0];
        Console.Write(average[j].ToString("f1") + "; ");   
    }    
}