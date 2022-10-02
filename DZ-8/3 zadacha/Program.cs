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

int[,] matrix1 = new int[n,m];
int[,] matrix2 = new int[n,m];
int[,] matrix3 = new int[n,m];
InputMatrix(matrix1);
InputMatrix(matrix2);
for(int i = 0; i < matrix1.GetLength(0);i++)
{
    for(int j = 0; j < matrix1.GetLength(1);j++)
    {
        matrix3[i,j] = matrix1[i,j] * matrix2[i,j];       
    }
}
PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);
Console.WriteLine();
PrintArray(matrix3);


