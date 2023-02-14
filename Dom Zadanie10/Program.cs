Console.Clear();
Console.WriteLine("Введите трёхзначное число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Вторая цифра данного числа " + a % 100 / 10);