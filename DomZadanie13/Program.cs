Console.Clear();
Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine());
if(a < 100)
{
    Console.WriteLine("третьей цифры нет");
} 
else 
{
    int i = 0; 
    while (a > 999)
    {
        i++;
        a = a /10;
    }
    int tri = a % 10;
    Console.WriteLine("Третья цифра " + tri);
}

Console.Clear();
Console.WriteLine("Введите цифру обозначающую день недели");
int a = int.Parse(Console.ReadLine());
if (a > 7 || a < 1)
{
    Console.WriteLine("Такого дня недели нет");
}
else 
{   
    if(a == 6 || a == 7) Console.WriteLine("ДА");
    else Console.WriteLine("НЕТ");
}