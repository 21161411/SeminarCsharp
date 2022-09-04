Console.WriteLine("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n<100 || n > 999)
{
    Console.WriteLine("Неверное число, повторите. ");
    n = Convert.ToInt32(Console.ReadLine());
}    
n = (n % 100) - (n % 10);
n = n / 10;
Console.Write(n);

