// Zadanie 9
int x = 123;

int Reverse(int x)
{
    string numberString = x.ToString();
    char[] charArray = numberString.ToCharArray();
    Array.Reverse(charArray);
    string reverserNumberString = new string(charArray);
    int reversed = Convert.ToInt32(reverserNumberString);

    return reversed;
}

Console.WriteLine($"{x} -> {Reverse(x)}");
