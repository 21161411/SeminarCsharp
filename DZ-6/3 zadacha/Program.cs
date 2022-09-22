void PrintArray(int[,] arr)
{
     for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}" + " ");
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
            arr[i,j] = new Random().Next(1,100);
        }
    }
}
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [n,m];
int x = 0;

FillArray(array);
PrintArray(array);

for(int i = 0; i < n/2; i++)
{
    for(int j = 0; j < m; j++)
    {
        x = array[i,j];
        array[i,j] = array[n-i-1,j];
        array[n-i-1,j] = x;
    }
}
Console.WriteLine();
PrintArray(array);
