Console.Clear();
Console.Write("Input number from 1 to 7: ");
int day = int.Parse(Console.ReadLine());
if (day == 6 || day == 7){
    Console.WriteLine("Да, сегодня выходной");
}
else {
    Console.WriteLine("Нет, сегодня будни");
}