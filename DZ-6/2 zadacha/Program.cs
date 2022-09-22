Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("y = " + Convert.ToString(k1) + " * x + " + Convert.ToString(b1) );
Console.WriteLine("y = " + Convert.ToString(k2) + " * x + " + Convert.ToString(b2) );

double x = 0;
double y = 0;

x = (-b1 + b2)/(k1-k2);
double x1 = x;
y = k2*x + b2;
Console.WriteLine("Точка пересечения: (" + Math.Round(x1, 2) + "; " + Math.Round(y, 2) + ")");



