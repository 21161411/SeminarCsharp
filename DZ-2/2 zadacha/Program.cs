Console.Clear();
void Numbers()
{
    int n = Convert.ToInt32(Console.ReadLine());
    if (n >= 100) Console.WriteLine(Convert.ToString(n)[2]);
    else
    Console.WriteLine("Третьей цифры нет");
}   

Numbers();