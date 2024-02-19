
Console.WriteLine("Fibonacci numbers");
while (true)
{
    var userInput = Console.ReadLine();
    int number= Convert.ToInt32(userInput);
    if(number>=0)
    FibonaciCounts(number);
    else break;
}


void FibonaciCounts(int len)
{
    int a = 0, b = 1, c = 0;
    Console.Write("{0} {1}", a,b);
    for (int i = 2; i < len; i++)
    {
        c= a + b;
        Console.Write(" {0}", c);
        a= b;
        b= c;
    }
}
