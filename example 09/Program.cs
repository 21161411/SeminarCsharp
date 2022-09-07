Console.Clear();
void Numbers()
{
    int a = Convert.ToInt32(Console.ReadLine());

    if (a%7 == 0 && a%23 == 0)
        Console.WriteLine("Кратно");
    else
    Console.WriteLine("Не кратно");

    


}

Numbers();