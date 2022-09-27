// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]; 6, 1, 33 -> [6, 1, 33].
Console.Clear();
Console.Write("Введите 8 чисел через запятую: ");
string str = Console.ReadLine();
int[] array = ReturnArray(str);


int[] ReturnArray(string str)
{
    int[] nums = str.Split(",").Select(int.Parse).ToArray();
    int n = nums.Length;
    Console.Write("Результат: [");
    for(int i=0; i<n-1; i++) Console.Write(nums[i] + ", ");
    Console.Write(nums[n-1] + "]");
    return nums;
}