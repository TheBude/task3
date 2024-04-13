//Tempiratura
Console.WriteLine("Salom Men tempiraturani o'giruvchi dasturman!");

Console.Write("Timperaturani Selsiyusda kiriting: ");
string op = Console.ReadLine();
int temp = Convert.ToInt32(op);

Console.WriteLine($"{temp} °C ni  Fahrenheit yoki Kelvin ga ko'chiraylikmi");

Console.Write(" Fahrenheit ga bo'lsa '1', Kelvin bo'lsa '2' ni kiriting:  ");
string num = Console.ReadLine();

switch(op)
{
    case "0":
        Console.WriteLine($" 0 °C selsiy 32 °F Fahrenheit ga teng\n 0 °C selsiy 273.15 K kelvin ga teng");
        break;
    default:
        Console.WriteLine("afc");
        break;
}

switch(num)
{
     case "1":
            Console.WriteLine($"{temp} °C selsiy {temp * 33.8} °F Fahrenheit ga teng");
            break;
     case "2":
            Console.WriteLine($"{temp} °C selsiy {temp * 274.15} K kelvin ga teng");
            break;
     default:
            Console.WriteLine("Bunaqa Operatsiya Yuq");
            break;
}