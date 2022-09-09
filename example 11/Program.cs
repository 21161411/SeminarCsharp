Console.Write("Введите координаты X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if(x> 0 && y > 0) Console.WriteLine("Первая четверть");
else if (x < 0 && y > 0) Console.WriteLine("Вторая четверть");
else if (x > 0 && y < 0) Console.WriteLine("Четвертая четверть");
else if (x < 0 && y < 0) Console.WriteLine("Третья четверть");
