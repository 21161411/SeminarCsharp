int n = Convert.ToInt32(Console.ReadLine());
double x = 0;
double y = 1;
double z = 0;

for(int i = 0; i < n; i++)
{
    Console.Write(x + ", ");
    z = x + y;
    x = y;
    y = z;
    
    
}
