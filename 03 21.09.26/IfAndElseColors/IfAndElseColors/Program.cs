using System.Drawing;

namespace IfAndElseColors
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("vali värv red, blue, green või white!");

            string input = Console.ReadLine();

            if (input == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            else if (input == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
            else if (input == "blue")
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            else if (input == "white")
            {
                Console.BackgroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("pole seda värvi");
            }
        }
    }
}