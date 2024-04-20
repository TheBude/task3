//harflarni hisoblavchi
Console.Write("Matn yoki so'z kiriting: ");
string text = Console.ReadLine();

Dictionary<char, int> count = new Dictionary<char, int>();

foreach (char letter in text)
{
    if (count.ContainsKey(letter))
    {
        count[letter]++;
    }
    else
    {
        count[letter] = 1;
    }
}

foreach(var kvp in count)
{
    Console.WriteLine($"'{kvp.Key} : '{kvp.Value}' Marta");
}