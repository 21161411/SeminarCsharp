
Console.Write("Введите X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)));