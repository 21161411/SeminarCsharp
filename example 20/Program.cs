void Fillarray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100,101);

    }
}

int[] Change(int[] array)
{
    for(int j = 0; j < array.Length; j++)
    {
        array[j] = -array[j];

    }
    return array;
}
int[] arr = new int[10];
Fillarray(arr);
Console.WriteLine(string.Join(" ", arr));
Console.WriteLine(string.Join(" ", Change(arr)));