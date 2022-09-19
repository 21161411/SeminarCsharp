void Fillarray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }

}
int[] array = new int [10];
Fillarray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");

int Numbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 0) count++;
    }
    return count;
}

Console.WriteLine(Numbers(array));