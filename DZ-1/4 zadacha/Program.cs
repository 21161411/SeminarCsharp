Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1)
{
    Console.WriteLine("Неверное число, введите другое:");
    n = Convert.ToInt32(Console.ReadLine());
}
for (int i = 1; i <= n; i++)
{
    if (i%2 <= 0) 
        Console.Write(i + " ");
    else
        Console.Write(" ");
}