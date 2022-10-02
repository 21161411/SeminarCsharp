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

int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[n,m];

FillArray(array);
PrintArray(array);

Console.WriteLine();

int t = 0;
for (int i = 0; i < array.GetLength(1); i++)
{
    t = array[0,i];
    array[0,i] = array[n - 1,i];
    array[array.GetLength(1) - 1,i] = t;
    
}

PrintArray(array);