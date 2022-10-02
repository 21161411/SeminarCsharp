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
void InputMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0);i++)
    {
        for(int j = 0; j < matrix.GetLength(1);j++)
        {
            matrix[i,j] = new Random().Next(1,10);   
        }
    }
}
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n,m];
InputMatrix(matrix);
PrintArray(matrix);
int min = matrix[0,0];
int x = 0;
while(x < matrix.GetLength(0))
{
    for(int i = 0; i < matrix.GetLength(1) - 1; i++)
    {
        for(int j = 0; j < matrix.GetLength(1) - i - 1; j++)
        {
            if(matrix[x, j] < matrix[x,j + 1])
            {   
                min = matrix[x, j+1];
                matrix[x, j + 1] = matrix[x,j];
                matrix[x,j] = min;
            }
        }
    }    
   x++;
}
Console.WriteLine();
PrintArray(matrix);

