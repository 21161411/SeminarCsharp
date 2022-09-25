
void FillArray (double[,] arr)
{
    for(int i = 0; i < arr.GetLength(0);i++)
        for(int j = 0; j < arr.GetLength(1);j++)
        {
            arr[i,j] = Math.Round(new Random().NextDouble() + new Random().Next(-10,10),2);
        }
}

void PrintArray(double[,] arr)
{
   for(int i = 0; i < arr.GetLength(0);i++)
    {    for(int j = 0; j < arr.GetLength(1);j++)
        {
             Console.Write($"{arr[i,j]}" + "\t");
        }
        Console.WriteLine(); 
    }
}

int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[n,m];

FillArray(array);
PrintArray(array);