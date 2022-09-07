int GenerateRandomNumbers()
{
    int n = new Random().Next(10,100);
    return n;
}

void CompraiseNumbers()
{
    int n = GenerateRandomNumbers();
    Console.WriteLine(n);
    int a = n / 10;
    int b = n % 10;
    if (a > b)
    Console.WriteLine(a);
    else if (a < b)
    Console.WriteLine(b);
    else
    Console.WriteLine("=");
}

CompraiseNumbers();