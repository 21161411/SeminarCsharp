void Fillarray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }

}
int[] arr = new int[10];
Fillarray(arr);
Console.WriteLine("[" + string.Join(", ", arr) + "]");
int Sum(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(i%2 > 0)
        {
            sum += array[i];
        }
    }
    return sum;
}
Console.WriteLine(Sum(arr));