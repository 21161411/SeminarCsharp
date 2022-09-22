int n = Convert.ToInt32(Console.ReadLine());
int x = 0;
string result = "";
while(n > 0)
{
    x = n % 2;
    result = Convert.ToString(x) + result;
    n = n / 2;
}
Console.WriteLine(result);