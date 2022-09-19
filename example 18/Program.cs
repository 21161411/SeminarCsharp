int[] array = new int[8];

void FillArray(int[] array)
{
    int i = 0;
    while(i < array.Length)
    {
        array[i] = new Random().Next(0,2);
        i++;
    }
}

FillArray(array);

// void PrintArray(int[] arr)
// {
//     int position = 0;
//     while(position < arr.Length)
//     {
//         Console.Write(arr[position] + " ");
//         position++;
//     }


// }

//PrintArray(array);

Console.WriteLine("[" + string.Join(", ", array) + "]");