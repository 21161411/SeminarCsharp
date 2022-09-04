Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (a >= b)
max = a;
else
max = b;
if (max <= c)
{   max = c;
    Console.WriteLine(max);
}
else
Console.WriteLine(max);