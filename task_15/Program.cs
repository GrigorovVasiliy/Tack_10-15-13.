Console.Clear();

Console.WriteLine("Введите день недели: ");
int a = Convert.ToInt32(Console.ReadLine());

while(a < 1 || a > 7){
    Console.WriteLine("Вы ошиблись, введите повторно: ");
    a = Convert.ToInt32(Console.ReadLine());}
if (a == 6 || a == 7)
    Console.WriteLine("Это выходной!");
else
    Console.WriteLine("Будний день");