Console.Clear();
int[] array = new int[100];
void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(1, 100);
        index++;
    }
}

void PrintArray(int[] ar)
{
    int count = ar.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(ar[position] + " ");
        position ++;
    }
}

FillArray(array);
PrintArray(array);
Console.WriteLine();
int MaxIndex(int[] array)
{
    int indexofmax = -1;
    int max = -1;
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] > max) 
        {
            max = array[index];
            indexofmax = index;             
        }
    }
    return max;
}
int result1 = MaxIndex(array);
Console.WriteLine(MaxIndex(array));

int SecondMax(int[] array)
{
    int max2 = 0;    
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > max2 && array[i] != result1)
        {
            max2 = array[i];
        }
    }
    return max2;
}
Console.WriteLine(SecondMax(array));
