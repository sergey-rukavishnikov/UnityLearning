using System;

namespace simple_wallet
{
    class Program
    {
        static void Main(string[] args)
        {
            int account = 5000;
            Console.WriteLine($"On your account now {account} rubles");
            Console.WriteLine("Enter purchase price: ");
            int.TryParse(Console.ReadLine(), out int price_1);
            account -= price_1;
            Console.WriteLine($"On your account now {account} rubles");
            Console.WriteLine("Enter purchase price: ");
            int.TryParse(Console.ReadLine(), out int price_2);
            account -= price_2;
            Console.WriteLine($"On your account now {account} rubles");
            Console.WriteLine("Enter purchase price: ");
            int.TryParse(Console.ReadLine(), out int price_3);
            account -= price_3;
            Console.WriteLine($"On your account now {account} rubles");
        }
    }
}
