int n = Convert.ToInt32(Console.ReadLine());
int k = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int[] arrayResult = new int[n];

for(int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());

}
Console.WriteLine(string.Join(", ", array));

k = k % n;
if(k > 0)
{
    for(int i = 0; i < k; i++)
    {
        arrayResult[i] = array[array.Length - k + i];
    }
    Console.WriteLine(string.Join(", ", arrayResult));

    for(int i = 0; i < n - k; i++)
    {
        arrayResult[k + i] = array[i];
    }
}
else
{
    k = (-1) * k;
    for(int i = 0; i < k; i++)
    {
        arrayResult[array.Length - k + i] = array[i];
    }
    Console.WriteLine(string.Join(", ", arrayResult));
    
    for(int i = 0; i < n - k; i++)
    {
        arrayResult[i] = array[k + i];
    }
}
Console.WriteLine(string.Join(", ", arrayResult));