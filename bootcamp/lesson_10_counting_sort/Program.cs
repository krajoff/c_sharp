// Сортировка подсчётом
int[] array = GetRandomArray(10);
Console.WriteLine($"Массив из случайных чисел: [{String.Join(", ", array)}]");
int[] sortarray = SortCounting(array);
Console.WriteLine($"Массив после сортировки подсчётом: [{String.Join(", ", sortarray)}]");

int[] GetRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(-20, 20);
    return array;
}

int[] SortCounting(int[] array)
{
    int index = 0;
    int max = array.Max();
    int min = array.Min();

    int[] count = new int[max - min + 1];
    int[] sortarray = new int[array.Length];
    for (int i = 0; i < array.Length; i++) count[array[i] - min] += 1;
    for (int i = 0; i < count.Length; i++)
    {
        while (count[i]-- > 0)
        {
            sortarray[index] = i + min;
            index++;
        }

    }
    return sortarray;
}