//sonlarni tartiblash chatgpt dan foydalanildi
Console.Write("Iltimos, vergul bilan ajratib sonlarni kiriting: ");
string input = Console.ReadLine();
string[] tokens = input.Split(',');
int[] numbers = new int[tokens.Length];

for (int i = 0; i < tokens.Length; i++)
{
    numbers[i] = int.Parse(tokens[i].Trim());
}

// Tartiblash
Array.Sort(numbers);

Console.WriteLine("Tartiblangan qator:");
Console.WriteLine(string.Join(", ", numbers));

// Teskari tartiblash
Array.Reverse(numbers);
Console.WriteLine("Teskari tartib:");
Console.WriteLine(string.Join(", ", numbers));

// Agar switch operatori kerak bo'lsa, misol uchun quyidagi kabi
Console.WriteLine("Kerakli operatsiyani tanlang: 1 - Tartiblash, 2 - Teskari tartiblash");
string choice = Console.ReadLine();
switch (choice)
{
    case "1":
        Console.WriteLine("Tartiblangan qator:");
        Console.WriteLine(string.Join(", ", numbers.OrderBy(x => x)));
        break;
    case "2":
        Console.WriteLine("Teskari tartib:");
        Console.WriteLine(string.Join(", ", numbers.OrderByDescending(x => x)));
        break;
    default:
        Console.WriteLine("Noto'g'ri tanlov!");
        break;
}