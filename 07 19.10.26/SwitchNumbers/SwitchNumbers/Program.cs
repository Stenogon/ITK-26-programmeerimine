namespace SwitchNumbers
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");

            string input = Console.ReadLine();

            switch (input)
            {
                case "10":
                    Console.WriteLine("you are 10");
                    break;
                case "20":
                    Console.WriteLine("you are 20");
                    break;
                case "30":
                    Console.WriteLine("you are 30");
                    break;
                default:
                    Console.WriteLine("something else: " + input);
                    break;
            }
        }
    }
}