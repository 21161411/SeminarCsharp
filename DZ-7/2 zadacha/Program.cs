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
            arr[i,j] = new Random().Next(-10,11);
        }
    }
}

int x = new Random().Next(2,6);
int y = new Random().Next(2,6);
int[,] array = new int[x,y];

FillArray(array);
PrintArray(array);
Console.WriteLine();

Console.Write("Укажите строку: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите столбец: ");
int m = Convert.ToInt32(Console.ReadLine());

if( n < array.GetLength(0))
{
    if( m < array.GetLength(1)) Console.WriteLine("Значение указанного элемента равно: " + array[n,m]);
    else Console.WriteLine("Нет указанного элемента");
} 
else Console.WriteLine("Нет указанного элемента");
