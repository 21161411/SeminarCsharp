int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

int Math(int a, int  b)
{
    if(b == 0) return 1;
    return Math(a, b-1) * a;

}

Console.WriteLine(Math(a,b));