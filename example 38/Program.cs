int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

// int[] matrix = new int[n];
// for(int i = 0; i < n; i++)
// {
//     matrix[i] = m;
//     m++;
// }
// Console.WriteLine("[" + string.Join(", ", matrix) + "]");

string PrintNumber(int m, int n)
{
    if(n == m) return $"{m}";
    return PrintNumber(m, n - 1) + $" {n}";

}
Console.WriteLine(PrintNumber(m,n));
