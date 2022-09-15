int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(Math.Pow(a, b));
int result = a;
int i = 1;
while(i < b)
{
    result *= a;
    i++;
}

Console.WriteLine(result);



