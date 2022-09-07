Console.Clear();
void Numbers()
{
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    if (a*a == b || b*b == a)
        Console.WriteLine("Да, являются. ");
    else
        Console.WriteLine("Нет, не являются");



}

Numbers();