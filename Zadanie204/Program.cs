// Zadanie 4
double kwota, procent, odsetki = 0, podatek = 0.19, zysk;
int czas;

Console.Write("Podaj kwotę którą chcesz wpłacić: ");
kwota = Convert.ToInt32(Console.ReadLine());

Console.Write("Podaj wysokość oprocentowania lokaty w skali roku: ");
procent = Convert.ToInt32(Console.ReadLine());

Console.Write("Podaj ile miesięcy będziesz oszczędzać: ");
czas = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < czas; i++)
{
    odsetki += kwota * procent / 100 / czas;
    kwota += kwota * procent / 100 / czas;
}

zysk = odsetki - (odsetki * podatek);

Console.WriteLine("Przychód: " + odsetki);
Console.WriteLine("Podatek: " + (odsetki * podatek));
Console.WriteLine("Zysk: " + zysk);
