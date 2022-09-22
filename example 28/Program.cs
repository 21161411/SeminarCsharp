void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void Copy(int[] copy, int[] paste)
{
    for(int j = 0; j < copy.Length; j++)
    {
        paste[j] = copy[j];
    }
}

int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];

FillArray(arr);
Console.WriteLine(string.Join(", ",arr));

int [] array = new int[n];
Console.WriteLine(string.Join(", ",array));

Copy(arr, array);
Console.WriteLine(string.Join(", ",array));