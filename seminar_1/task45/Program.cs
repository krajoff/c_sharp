// Задача 45: Напишите программу, которая будет создавать 
// копию заданного массива с помощью поэлементного копирования.
Console.Clear();
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] array = GetRandomArray(size);
Console.WriteLine($"Массив из случайных чисел: [{String.Join(", ", array)}]");
int[] arraycopy = CopyArray(array);
Console.WriteLine($"Копия массива: [{String.Join(", ", arraycopy)}]");

int[] GetRandomArray(int size){
    int[] array = new int[size];
    for(int i = 0; i < size; i++) 
        array[i] = new Random().Next(-100,101);
    return array;
}

int[] CopyArray(int[] array){
    int[] arraycopy = new int[array.Length];
    int i = 0;
    while(i < array.Length){
        arraycopy[i] = array[i];
        i++;
    }
    return arraycopy;
}