// Задача 43: Напишите программу, которая найдёт точку пересечения двух 
// прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения 
// b1, k1, b2 и k2 задаются пользователем. b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();
Console.Write("Введите b1, k1, b2 и k2 через пробел: ");
string foo = Console.ReadLine();
double[] array = GetArray(foo);
double[] point = GetCrossPoint(array);
Console.Write($"Координаты точки пересения: ({point[0]}; {point[1]})");

double[] GetArray(string str)
{
    double[] nums = str
        .Split(" ")
        .Select(double.Parse)
        .ToArray();
    return nums;
}

double[] GetCrossPoint(double[] pt)
{
        double[] point = new double[2];
        point[0] = Math.Round((pt[2]-pt[0])/(pt[1]-pt[3]), 2);
        point[1] = Math.Round(pt[1]*(pt[2]-pt[0])/(pt[1]-pt[3])+pt[0], 2);
        return point;
}
