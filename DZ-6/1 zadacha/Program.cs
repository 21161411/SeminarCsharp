int n = Convert.ToInt32(Console.ReadLine());
int count = 0;
for(int i = 1; i <= n; i++)
{
    Console.Write("Введите число " + i +" : ");
    int x = Convert.ToInt32(Console.ReadLine());
    if(x > 0) count++;    

}
Console.WriteLine("Количество положительных чисел равно: " + count);