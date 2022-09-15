int n = Convert.ToInt32(Console.ReadLine());
double sum = 0;
while (n / 10 > 0 || n % 10 > 0)
{
    sum = sum + (n % 10);
    n /= 10;

}
Console.WriteLine(sum);