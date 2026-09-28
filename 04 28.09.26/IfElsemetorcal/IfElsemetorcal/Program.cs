using System.Reflection.Metadata;

namespace IfElsemetorcal
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("hello, world!");
            string input = Console.ReadLine();
            if (input == "Hello")
            {
                HelloMethod();
            }
            else
            {
                Console.WriteLine("that is trash");
            }
        }
        static void HelloMethod()
        {
            Console.WriteLine("hello friend");
        }
    }
}