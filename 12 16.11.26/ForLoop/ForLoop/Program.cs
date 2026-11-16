namespace ForLoop
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");

            int input = 4;
            for (int i = 1; i <= input; i++)
            {
                Console.WriteLine("see on rida number {0}", i);

                for (int j = 1; j <= 2; j++)
                {
                    Console.WriteLine("kill-koll");
                }
                Console.WriteLine("killadi-koll");
            }
        }
    }
}