namespace YesGame
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("sisesta sõna");
            string word = "";

            while (word != "yes")
            {
                Console.WriteLine("proovi veelkord!");
                word = Console.ReadLine();
            }
            Console.WriteLine("good boy");
        }
    }
}