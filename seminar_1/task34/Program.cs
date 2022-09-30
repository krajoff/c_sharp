// Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве. [345, 897, 568, 234] -> 2
Console.Clear();
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] array = GetRandomArray(size);
Console.WriteLine($"Массив: [{String.Join(", ", array)}]");
Console.WriteLine($"Количество четных чисел в массиве: {GetEvenNumber(array, size)}");

int[] GetRandomArray(int size) {
    int[] array = new int [size];
    for(int i=0; i<size; i++) array[i] = new Random().Next(100,1000);
    return array;
}

int GetEvenNumber(int[] array, int size) {
    int evennumber = 0;
    for(int i=0; i<size; i++)
        evennumber += array[i]%2==0 ? 1 : 0;
    return evennumber;
}