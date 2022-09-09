Console.WriteLine("Введите X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

void Sum()
{
    double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    Console.WriteLine(result);
}

Sum();

