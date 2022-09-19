void Fillarray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() + new Random().Next(-100,100),3);
    }

}

double[] arr = new double[10];
Fillarray(arr);
Console.WriteLine("[" + string.Join(", ", arr) + "]");
double FindDiff(double[] array)
{
    double max = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max) max = array[i];

    }
    
    double min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < min) min = array[i];

    }
    double dif = max - min;
    return dif;
}

Console.WriteLine(FindDiff(arr));

