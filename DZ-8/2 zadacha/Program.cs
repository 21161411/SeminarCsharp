
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
if(n==m)
{
    Console.WriteLine("Массив не прямоугольный");
    n = Convert.ToInt32(Console.ReadLine());
    m = Convert.ToInt32(Console.ReadLine());
}
int[,] matrix = new int[n,m];
int[] array = new int[n];
InputMatrix(matrix);
PrintArray(matrix);
int i = 0;
int sum = 0;
while(i < matrix.GetLength(0))
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        sum += matrix[i,j];
    }
    array[i] = sum;
    sum = 0;
    i++;
}
Console.WriteLine();
Console.WriteLine(string.Join(", ", array));
int min = array[0];
int x = 0;
for(int k = 0; k < array.Length; k++)
{
    if(array[k] < min)
    {
        min = array[k];
        x = k;
    }

}
Console.WriteLine();
Console.WriteLine("Cтрока с наименьшей суммой элементов: "+ (x + 1) + " строка");