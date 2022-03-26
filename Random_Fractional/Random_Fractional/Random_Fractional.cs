using System;

namespace Random_Fractional
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            double random_number = rnd.Next(10, 50) / 10.0;
            Console.WriteLine(random_number);
        }
    }
}