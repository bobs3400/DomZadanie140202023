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