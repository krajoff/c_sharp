Console.Clear();
Console.Write("Input triple digits, please: ");
int n = int.Parse(Console.ReadLine());
if(n<100 || n>999) {
    Console.WriteLine("Incorrent number");
    return;
}
Console.Write("Result: ");
int SecondDigital = n%100;
SecondDigital = (SecondDigital - SecondDigital%10)/10;
Console.Write(SecondDigital);
