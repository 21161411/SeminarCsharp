Console.Write("Сколько посадили кустов: ");

int numbers = Convert.ToInt32(Console.ReadLine());
while(numbers < 3)
{
    Console.WriteLine("Мало кустов, посадите больше: ");
    numbers = Convert.ToInt32(Console.ReadLine());

}
//int numbers = new Random().Next(3, 1001);
int[] kusti = new int[numbers];
//int sum = 0;
//for(int i = 0; i < kusti.Length; i++)
// {
//     kusti[i] = new Random().Next(0,100);
//     sum = sum + kusti[i];
//     if(sum >= 1000) break;

// }
// Console.WriteLine(string.Join(" ", kusti));
for (int i = 0; i < numbers; i++)
{   
    Console.Write("Количество ягод на " + (i+1) + " кусте: ");
    kusti[i] = Convert.ToInt32(Console.ReadLine());

}
Console.WriteLine();
Console.WriteLine(string.Join(" ", kusti));
int x = kusti[numbers - 1] + kusti[0] + kusti[numbers - 2];
int y = kusti[numbers - 1] + kusti[0] + kusti[1];
int max = 0;
for(int j = 1; j < kusti.Length -1 ; j++)
{
    int max2 = kusti[j-1] + kusti[j] + kusti[j+1];
    if (max < max2) max = max2;
}
if(x > max) max = x;
if(y > max) max = y;
Console.WriteLine();

Console.WriteLine("Рекорд сбора: " + max);