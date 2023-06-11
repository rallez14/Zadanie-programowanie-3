// Zadanie 2
int fib(UInt128 x)
{
    if (x == 0)
    {
        return 0;
    }
    if (x == 1)
    {
        return 1;
    }
    return fib(x - 1) + fib(x - 2);
}

UInt128 n;
Console.Write("Wpisz ilość liczb ciągu Fibonacciego do obliczenia: ");
n = Convert.ToUInt64(Console.ReadLine());
for (UInt128 i = 1; i < n; ++i)
{
    Console.WriteLine("[{0}] {1}", i, fib(i));
}
