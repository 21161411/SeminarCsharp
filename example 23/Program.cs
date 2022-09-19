void Fillarray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }

}

int[] arr = new int [5];
Fillarray(arr);
Console.WriteLine(string.Join(", ", arr));


void Sum(int[] array)
{
    int lenArray;
    if(array.Length%2 == 0) lenArray = array.Length / 2;
    else lenArray = array.Length / 2 + 1;
    
    int[] ResultArray = new int[lenArray];  
    
    for(int j = 0; j < lenArray; j++)
    {
        ResultArray[j] = array[j] * array[array.Length - j - 1];
        
    }
   Console.WriteLine("Конечный массив: [" + string.Join(", ", ResultArray) + "]");
}

Sum(arr);