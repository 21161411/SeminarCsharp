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

void InputMatrix(int[,] matrix, int[] array)
{
    int k = 0;
    for(int i = 0; i < matrix.GetLength(0);i++)
    {
        for(int j = 0; j < matrix.GetLength(1);j++)
        {
            int x = new Random().Next(1,10);
            matrix[i,j] = x;
            array[k] = x;
            k++;
        }
    }
}
void ReleaseMatrix(int[] array)
{
int[] helpArray = new int [array.Length];
    
    for(int i = 0; i < array.Length; i++)
    {
        int count = 1;
        bool flag = true;
        foreach (int el in helpArray)
        {
            if(array[i] == el)
                flag = false;
        }
        if(flag)
        {
            for(int j = 0; j < array.Length; j++)
            {   
                if(array[i] == array[j] && i != j) 
                    count++;
            }
            helpArray[i] = array[i];
            Console.WriteLine(array[i] + " встречается " + count + " раз");
        }
    }    
}

int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n,m];
int[] matrix = new int[n*m];
InputMatrix(array,matrix);
PrintArray(array);
Console.WriteLine();
ReleaseMatrix(matrix);