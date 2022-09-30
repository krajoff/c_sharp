// Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива. [3 7 22 2 78] -> 76

Console.Clear();
Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
double[] array = GetRandomArray(size);
Console.WriteLine($"Массив вещественных чисел от 0 до 100: [{String.Join(", ", array)}]");
Console.WriteLine($"Разница между наибольшим и наименьшим элеметами массива: {GetDeltaMaxMin(array)}");

double[] GetRandomArray(int size){
    double[] array = new double[size];
    for(int i = 0; i < size; i++){
        double value = new Random().NextDouble()*100;
        array[i] = Math.Round(value, 2);
    }
    return array;
}

double GetDeltaMaxMin(double []array){
    double max = array[0], min = max;
    foreach(double el in array){
        max = (el > max) ? el : max;
        min = (el < min) ? el : min;
    }
    return Math.Round(max-min, 2);
}