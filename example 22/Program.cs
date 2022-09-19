void Fillarray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }

}

int[] arr = new int[123];
Fillarray(arr);
Console.WriteLine(string.Join(", ", arr));

int Find(int[] array)
{
    int count = 0;
    for(int j = 0; j < array.Length; j++)
    {
        if(array[j] >= 10 && array[j] <= 99) count ++;
    }
    return count;
}

Console.WriteLine("Количество чисел в промежутке: " + Find(arr));