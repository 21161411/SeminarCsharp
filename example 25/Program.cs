int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if(a < b + c && b < a + c && c < a + b)
    Console.WriteLine("Да может существовать");        
else Console.WriteLine("Нет не может существовать");    