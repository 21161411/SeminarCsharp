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
            arr[i,j] = new Random().Next(1,10);
        }
    }
}

int[,] Replace(int[,] arr)
{
    int t = 0;
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = i + 1; j < arr.GetLength(1); j++)
        {
            t =  arr[i,j];
            arr[i,j] = arr[j,i];
            arr[j,i] = t;
        }
    }
    return arr;
}

int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
if(n != m) Console.WriteLine("no");
int[,] array = new int[n,m];
FillArray(array);
PrintArray(array);
Console.WriteLine();
PrintArray(Replace(array));