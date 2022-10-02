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

int stringOfMin = 0;
int columnOfMin = 0;
InputMatrix(matrix);
PrintArray(matrix);
Console.WriteLine();
int min = matrix[0,0];
for(int i = 0; i < matrix.GetLength(0);i++)
{
    for(int j = 0; j < matrix.GetLength(1);j++)
    {
        if (matrix[i,j] < min) 
        {
            min = matrix[i,j];
            stringOfMin = i;
            columnOfMin = j;
            
        }    
    }
}
Console.WriteLine(stringOfMin);
Console.WriteLine(columnOfMin);

for(int i = 0; i < matrix.GetLength(0); i++)
{
    
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        if(i != stringOfMin && j != columnOfMin)
        {
            Console.Write($"{matrix[i,j]}" + "\t");
        }
    }
    Console.WriteLine();   
}