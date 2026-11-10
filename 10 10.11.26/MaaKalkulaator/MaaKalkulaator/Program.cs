using System.Security.Cryptography;

namespace MaaKalkulaator
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");

            // 6371 km
            double maa = 6371000.0;
            double münt = 0.02575;

            double amount = 2 * Math.PI * maa;

            Console.WriteLine("maa ümbermõõt on " + amount / 1000 + "km");

            double how = amount / münt;
            Console.WriteLine("kahe euroseid laheb ümber maa {0:0}", how);
        }
    }
}