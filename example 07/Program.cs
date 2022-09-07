int Generator()
{
    int n = new Random().Next(100,1000);
    return n;
}

void NumberModification()
{
    int n = Generator();
    Console.WriteLine(n);

    //int a = n / 100;
   // int b = n % 10;

    //Console.WriteLine(a*10 + b);

    //Альтернатива
    Console.Write(Convert.ToString(n)[0]);
    Console.Write(Convert.ToString(n)[2]);
    

}

NumberModification();