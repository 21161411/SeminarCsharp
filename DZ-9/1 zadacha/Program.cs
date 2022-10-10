int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
//int sum = 0;
// while(n <= m)
// {
//     sum += n;
//     n++;
// }
// Console.WriteLine(sum);

int PrintNumber(int n, int m)
{
    if(n == m - 1) return 0;
    return PrintNumber(n - 1, m) + n;

}
Console.WriteLine(PrintNumber(n,m));