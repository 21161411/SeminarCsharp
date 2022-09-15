int n = Convert.ToInt32(Console.ReadLine());
int sum = 1;
int i = 2;
while(i <= n)
{
    sum *= i;
    i++;

}

Console.WriteLine(sum);