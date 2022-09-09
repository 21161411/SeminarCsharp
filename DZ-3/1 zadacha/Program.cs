Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int oldValue = number;
int newValue = 0;
if (number >= 10000 && number < 100000)
{
    while (number > 0)
    {
        int dig = number % 10;
        newValue = newValue * 10 + dig;
        number = number / 10;
    }
    if (newValue == oldValue)Console.WriteLine("Является. ");
    else Console.WriteLine("Не является. ");
}    
else Console.WriteLine ("Неверное число. ");