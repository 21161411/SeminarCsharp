void Fillarray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);

    }
}



string Check(int[] array, int number)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == number) 
        {   
            return "yes";
        }
    }
    return "no";
}


int[] arr = new int[10];
Fillarray(arr);
Console.WriteLine(string.Join(", ", arr));
Console.Write("Укажите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Check(arr, n));
