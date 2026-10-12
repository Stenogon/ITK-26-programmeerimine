namespace switchcolor
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");
            string input = Console.ReadLine();

            switch (input)
            {
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("see on punane");
                    break;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("see on roheline");
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("see on sinine");
                    break;
                case "white":
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("see on valge");
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("see on kollane");
                    break;
                default:
                    Console.WriteLine("sellist värvi minul pole");
                    break;
            }
        }
    }
}