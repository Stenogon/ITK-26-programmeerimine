using System.Diagnostics.CodeAnalysis;

namespace ifelsenestingprogram
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");
            string input = Console.ReadLine();

            if (input == "auto")
            {
                Console.WriteLine("sisesta auto suurus");
                string size = Console.ReadLine();

                if (size == "sedaan")
                {
                    Console.WriteLine("sul on sedaan");
                }
                else if (size == "kabriolet")
                {
                    Console.WriteLine("sul on kabriolet");
                }
            }
            else
            {
                Console.WriteLine("sõida jalgrataga pois!");
            }
        }
    }
}
