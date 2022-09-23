Console.Clear();
Console.Write("Введите пятизначное число, пожалуйста: ");
int n = int.Parse(Console.ReadLine());
if(n<10000 || n>99999) {
    Console.WriteLine("Некорректное число");
    return;
}

String str = n.ToString();
Console.Write($"{n} - ");
if(str[0]==str[4]&&str[1]==str[3]) Console.Write("да, палиндром");
else Console.Write("нет, не палиндром");