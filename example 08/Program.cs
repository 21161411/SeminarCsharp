
Console.Clear();
void InputNumbers()
{
    Console.Write("Напишите первое число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Напишите второе число: ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(a + " " + b);
    if (a % b == 0)
        Console.WriteLine("Кратно");
    else
        Console.WriteLine("Остаток " + a%b);
}

InputNumbers();