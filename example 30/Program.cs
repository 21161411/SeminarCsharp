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
            arr[i,j] = new Random().Next(4,10);
        }
    }
}

int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[n,m];

FillArray(array);
PrintArray(array);

for(int i = 1; i < array.GetLength(0); i= i + 2)
{
    for(int j = 1; j < array.GetLength(1); j= j + 2)
    {
        array[i,j] = array[i,j] * array[i,j];
    }
}
Console.WriteLine();
PrintArray(array);