Console.Clear();
Console.Write("Input number, please: ");
int n = int.Parse(Console.ReadLine());
if(n<100) {
    Console.WriteLine("Третьей цифры нет");
    return;
}
int ThirdDigital = n;
if(n<1000) ThirdDigital = n%10;
//if(n<10000) ThirdDigital = (n - n%1000)/100;
//int ThirdDigital = n%1000;
//ThirdDigital = (ThirdDigital - ThirdDigital%100)/100;
Console.Write("Result: " + ThirdDigital);