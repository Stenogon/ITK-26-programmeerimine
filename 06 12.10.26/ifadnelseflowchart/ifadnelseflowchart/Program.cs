namespace ifadnelseflowchart
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("sisesta infot");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("you entered 1");
            }
            else if (input == "2")
            {
                Console.WriteLine("you entered 2");
            }
            else
            {
                Console.WriteLine("you entered shit knows what");
            }
        }
    }
}