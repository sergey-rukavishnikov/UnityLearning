using System;

namespace kukushka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in your age: ");
            double.TryParse(Console.ReadLine(), out double age);
            Random rnd = new Random();
            double remainder = rnd.Next(0, (int)Math.Floor(365.25 * (100 - age)));
            Console.WriteLine($"You have {remainder} days to live");
        }
    }
}
