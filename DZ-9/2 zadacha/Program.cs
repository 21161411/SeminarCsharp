int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int A(int m, int n)
{
    if(m == 0) return n + 1;
    else if(m > 0 && n == 0) return A(m - 1, 1);
    return A(m - 1, A(m, n - 1));
}
Console.WriteLine(A(m,n));