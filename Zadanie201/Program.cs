// Zadanie 1
int a, b, result = 1;

int Pow(int a, int b) 
{ 
    for (int i = 0; b > i; i++) 
    {
        result *= a;
    }

    return result;
}

try
{
    Console.Write("Podaj podstawę: ");
    a = Convert.ToInt32(Console.ReadLine());

    Console.Write("Podaj wykładnik: ");
    b = Convert.ToInt32(Console.ReadLine());

    if (a < 0 || b < 0)
    {
        Console.WriteLine("Podana liczba nie jest liczbą naturalną.");
        System.Environment.Exit(0);
    }
    else
    {
        Pow(a, b);
        Console.WriteLine("{0} do potęgi {1} = {2}", a, b, result);
    }
}
catch (Exception)
{
    Console.WriteLine("Podana liczba nie jest liczbą naturalną.");
}

