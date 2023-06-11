// Zadanie 8
int min = 1, max = 20;
List<int> guesses = new List<int>();

Console.WriteLine("Wybierz liczbę z przedziału 1-20, a ja ją zgadnę!");

while (true)
{
    int guess, response;

    do
    {
        guess = (min + max) / 2;
    } while (guesses.Contains(guess));

    Console.WriteLine($"Twoja liczba to {guess}?");

    response = Convert.ToInt32(Console.ReadLine());

    guesses.Add(guess);

    if (response > 0)
    {
        max = guess - 1;
    }
    else if (response < 0)
    {
        min = guess + 1;
    }
    else
    {
        Console.WriteLine($"Wygrałem! Twoja liczba to {guess}.");
        break;
    }

    if (min > max)
    {
        Console.WriteLine("Twoje odpowiedzi nie są prawdziwe!");
        break;
    }
}