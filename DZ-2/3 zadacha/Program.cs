Console.Clear();

void TypeOfDay()
{
    int n = Convert.ToInt32(Console.ReadLine());
    if (n < 1 || n > 7) Console.WriteLine("Неверное число. ");
    else if (n < 6 )
    Console.WriteLine("Рабочий день");
    else if (n > 5 )
    Console.WriteLine ("Выходной день");

}

TypeOfDay();