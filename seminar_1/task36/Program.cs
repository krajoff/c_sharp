// Задайте одномерный массив, заполненный случайными 
// числами. Найдите сумму элементов, стоящих на нечётных 
// позициях. [3, 7, 23, 12] -> 19   [-4, -6, 89, 6] -> 0
Console.Clear();
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] array = GetRandomArray(size);
Console.WriteLine($"Массив: [{String.Join(", ", array)}]");
Console.WriteLine($"Сумма элементов на нечётных позициях: {GetSumOddElement(array, size)}");

int[] GetRandomArray(int size){
    int[] array = new int[size];
    for(int i = 0; i < size; i++) 
        array[i] = new Random().Next(-100,101);
    return array;
}

int GetSumOddElement(int[] array, int size){
    int sum = 0;
    for(int i = 0; i < size; i++)
        sum += (i%2==0) ? 0 : array[i];
    return sum;    
}c