Console.Clear();

Console.Write("Веедите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 100)
    Console.WriteLine($"Число имеет меньше 3-х цифр");
else
{
    while (n > 999) 
    n = n / 10;
    Console.WriteLine($"Третья цифра числа: { n % 10}.");
}

