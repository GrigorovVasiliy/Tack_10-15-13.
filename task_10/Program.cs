Console.Clear();

Console.Write("Веедите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine()), n1, n2, n3;

n1 = n / 100;
n2 = n / 10 % 10;
n3 = n % 10;

Console.WriteLine($"Вторая цифра числа: {n2}.");