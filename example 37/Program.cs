int factor(int n)
{
    if(n == 0) return 1;
    return factor(n -1) * n;

}
int n = 5;
Console.WriteLine(factor(n));