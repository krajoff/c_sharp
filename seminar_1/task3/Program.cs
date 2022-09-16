Console.Clear();
Console.WriteLine("Input number from 1 to 7");
int day = int.Parse(Console.ReadLine());
if (day == 1){
    Console.WriteLine("Today is monday");
}
else if (day == 2){
    Console.WriteLine("Today is tuesday");
}
else{
    if (day == 3)
        Console.WriteLine("Today is wednesday");
    else if (day == 4)
        Console.WriteLine("Today is thursday");
    else if (day == 5)
        Console.WriteLine("Today is friday");
    else if (day == 6)
        Console.WriteLine("Today is suturday");
    else if (day == 7)
        Console.WriteLine("Today is sunday");
    else 
        Console.WriteLine("It is out of range");
}