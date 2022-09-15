int [] array = new int[8];

for(int i = 0; i < 8; i++)
{
    int a = Convert.ToInt32(Console.ReadLine());
    array[i] = a;

}

//Console.Write("Введите количество элементов массива: ");
//int n = Convert.ToInt32(Console.ReadLine());
//int[] array = new int[n];
// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 100);

// }

 Console.WriteLine("[" + string.Join(", ", array) + "]");

