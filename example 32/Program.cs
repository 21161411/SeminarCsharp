void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}" + " ");
           
    }
}

void FillArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write("Введите число " + (i+1) + ": ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}


int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int m = Convert.ToInt32(Console.ReadLine());
bool flag = true;

for(int i = 0; i < m; i++)
{
    int k = 0;
    int x = Convert.ToInt32(Console.ReadLine());
    for(int j = 0; j < n; j++)
    {
        if(array[j] == x) k++;
    }
    if(k < 1) flag = false;

}
if (flag)
    Console.WriteLine("YES");
else 
    Console.WriteLine("NO");





