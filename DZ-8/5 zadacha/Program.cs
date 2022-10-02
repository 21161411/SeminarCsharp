void PrintArray(int[,] arr)
{
     for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}" + "\t");
        }
    Console.WriteLine();   
    }
}

int n = 8;
int m = 8;
int [,] matrix = new int[n,m];
int number = 1;
int srez = 0;
int z = 0;
bool flag = true;
while(flag)
{
    
    for(int i = 0 ; i <= matrix.GetLength(1) - 1 -2*srez; i++) 
    {
        matrix[srez,i+srez] = number + z;
        number++;
    }
    z--;
    for(int j = srez; j <= matrix.GetLength(0) - 1 - srez; j++)
    {
        matrix[j, m - 1 - srez] = number + z;
        number++;
    }
    z--;
    for(int k = matrix.GetLength(1) - 1 - srez ; k >= srez; k--)
    {
        matrix[n - 1 - srez, k] = number + z;
        number++;
        
    }
    z--;
    if(matrix[n-1 - srez - 1, srez + 1] != 0) flag = false;
    for(int l = matrix.GetLength(0) - 1 - srez; l > srez; l--)
    {
        matrix[l, 0 + srez] = number + z;
        number++;
        
    }
    srez++;
}

PrintArray(matrix);



