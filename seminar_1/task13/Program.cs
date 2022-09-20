Console.Clear();
Console.Write("Input number, please: ");
int n = int.Parse(Console.ReadLine());
if(n<100) {
    Console.WriteLine("Третьей цифры нет");
    return;
}
int counter = 100, pow = 2;
while (n%counter < n) {
    counter = counter*10;
    pow++;
}
int ThirdDigital = n;
double e = Math.Pow(10, (pow-1));
if(n<1000) ThirdDigital = n%10;
if(n>1000) ThirdDigital = (n%(counter/100)-n%(counter/1000))/(counter/1000);
Console.WriteLine("ThirdDigital: " + ThirdDigital);