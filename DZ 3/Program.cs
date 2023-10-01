// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

class Converter
{
    protected decimal DollarRate;
    protected decimal EuroRate;
    public Converter(decimal dollarRate, decimal euroRate)
    {
        DollarRate = dollarRate;
        EuroRate = euroRate;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        decimal dollarRate = 0, euroRate = 0, Amount = 0;
        while (true)
        {
            if (dollarRate == 0)
            {
                Console.WriteLine("Введiть курс долара (грн/дол):");
                if (!decimal.TryParse(Console.ReadLine(), out dollarRate))
                {
                    Console.WriteLine("Неправильний формат курсу долара.");
                    continue;
                }
            }
            if (euroRate == 0)
            {
                Console.WriteLine("Введiть курс євро (грн/євро):");
                if (!decimal.TryParse(Console.ReadLine(), out euroRate))
                {
                    Console.WriteLine("Неправильний формат курсу євро.");
                    continue;
                }
            }
            if (Amount == 0)
            {
                Console.WriteLine("Введiть суму грошей: ");
                if (!decimal.TryParse(Console.ReadLine(), out Amount))
                {
                    Console.WriteLine("Неправильний формат суми грошей.");
                    continue;
                }
            }

            Converter converter = new Converter(dollarRate, euroRate);

            while (true)
            {
                Console.WriteLine("1. Перевести грн в долари");
                Console.WriteLine("2. Перевести грн в євро");
                Console.WriteLine("3. Перевести долари в грн");
                Console.WriteLine("4. Перевести євро в грн");
                Console.WriteLine("5. Вийти");
                Console.WriteLine("Оберiть опцiю (1-5):");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"Сума в доларах: {Math.Round((Amount / dollarRate), 2)}$");
                        break;

                    case "2":
                        Console.WriteLine($"Сума в євро: {Math.Round((Amount / euroRate), 2)}€");
                        break;

                    case "3":
                        Console.WriteLine($"Сума в гривнях: {Math.Round((Amount * dollarRate), 2)}₴");
                        break;

                    case "4":
                        Console.WriteLine($"Сума в гривнях: {Math.Round((Amount * euroRate), 2)}₴");
                        break;

                    case "5":
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Невiрний вибiр опцiї.");
                        break;
                }
            }
        }
    }
}





