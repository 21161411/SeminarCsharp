void PrintArray(int[,,] arr)
{
    int z = 10;
    for(int i = 0; i < arr.GetLength(0); i++)
    {    
         for(int j = 0; j < arr.GetLength(1); j++)
        {
            for(int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i,j,k] = z;
                Console.WriteLine($"{arr[i,j,k]} ({i}, {j}, {k})");
                z++;
            }    
        }    
    }          
}
// void InputMatrix(int[,,] matrix)
// {
//     int a = 10;
//     for(int k = 0; k < matrix.GetLength(0); k++)
//     {    
//         for(int i = 0; i < matrix.GetLength(1);i++)
//         {
//             for(int j = 0; j < matrix.GetLength(2);j++)
//             {
//                 matrix[k,i,j] = a;
//                 a++;   
//             }
//         }
//     }
// }

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int o = Convert.ToInt32(Console.ReadLine());

int[,,] matrix = new int[m,n,o];
PrintArray(matrix);



// int[,,] matrix = new int[m,n,o];
// InputMatrix(matrix);
// int[,] array1 = new int[m,n];

// for(int k = 0; k < matrix.GetLength(2); k++)
// {
//     for(int i = 0; i < matrix.GetLength(0); i++)
//     {   
//         for(int j = 0; j < matrix.GetLength(1); j++)
//         {
//             array1[i,j] = matrix[i,j,k];
//             Console.Write("(" + Convert.ToString(i) + "," + Convert.ToString(j) + "," + Convert.ToString(k)+ "): " + array1[i,j] + "\t");
            
//         }
//         Console.WriteLine();
//     }
// }
