int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Console.WriteLine();
for(int i = 0; i < array.Length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());

}
Console.WriteLine();
int count = 0;
int countMax = 0;
for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 0) count++;

    else if(array[i] < 0) count = 0;

    if(countMax < count) countMax = count;

}
Console.WriteLine(countMax); 