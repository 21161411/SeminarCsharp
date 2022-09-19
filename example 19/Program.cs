void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9,10);
    }

}

int SumPositive(int[] array)
{
    int max1 = 0;
    for(int j = 0; j < array.Length; j++)
    {
        if(array[j] > 0) max1 += array[j];
    } 
    return max1;
}
int SumNegative(int[] array)
{
    int max2 = 0;
    for(int j = 0; j < array.Length; j++)
    {
        if(array[j] < 0) max2 += array[j];
    }
    return max2; 
}
 int[] arr = new int [12];
FillArray(arr);
Console.WriteLine("Исходный массив: [" + string.Join(", ", arr) + "]");

// for(int j = 0; j < array.Length; j++)
// {
//     if(array[j] < 0) max1 = max1 + array[j];
//     else max2 = max2 + array[j];

// }

Console.WriteLine("Сумма положительных: " + SumPositive(arr));
Console.WriteLine("Сумма отрицательных: " + SumNegative(arr));