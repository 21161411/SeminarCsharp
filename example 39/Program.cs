int n = Convert.ToInt32(Console.ReadLine());
int Sum(int n)
{
    if(n<10) return n;
    return Sum(n / 10) + n%10;

}
Console.WriteLine(Sum(n));


