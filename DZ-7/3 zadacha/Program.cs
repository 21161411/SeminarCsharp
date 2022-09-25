void PrintArray(int[,] arr)
{
     for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}" + "\t");
        }
    Console.WriteLine();   
    }
}
void FillArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(1,11);
        }
    }
}
double sum = 0;
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n,m];
double[] ar = new double[m];
FillArray(array);
PrintArray(array);
int x = 0;
while(x < m)
{
    for(int i = 0; i < n; i++)
    {
        sum = sum + array[i,x];
    }
    ar[x] = Math.Round(sum / n,3);
    x++;
    sum = 0;
}
Console.WriteLine(string.Join(", ", ar));