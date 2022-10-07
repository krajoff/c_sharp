// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2        1, -7, 567, 89, 223-> 4
Console.Clear();
Console.Write("Введите произвольное количество чисел через пробел: ");
string foo = Console.ReadLine();
int[] array = GetArray(foo);
Console.Write($"Количество чисел больше 0 составляет: {GetPositiveCount(array)}");

int[] GetArray(string str)
{
    int[] nums = str.Split(" ").Select(int.Parse).ToArray();
    return nums;
}

int GetPositiveCount(int[] array)
{
    int count = 0;
    foreach (int i in array)
    {
        count += (i > 0) ? 1 : 0;
    }
    return count;
}