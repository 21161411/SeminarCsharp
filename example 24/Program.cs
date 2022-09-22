void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 11);
    } 
}

void Change(int[] array)
{
    for(int j = 0; j < array.Length/2; j++)
    {
        int x = array[j];
        array[j] = array[array.Length - j - 1];
        array[array.Length - j - 1] = x;
    }
}

int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int [n];

FillArray(arr);
Console.WriteLine("[ " + string.Join(", ", arr) + " ]");

Change(arr);
Console.WriteLine("[ " + string.Join(", ", arr) + " ]");