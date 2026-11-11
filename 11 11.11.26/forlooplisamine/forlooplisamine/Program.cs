namespace forlooplisamine
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine();
            Console.WriteLine("\n\n");

            int sum = 0;

            for (int j = 1; j < 10; j++)
            {
                Console.WriteLine(sum = sum + j);
            }
        }
    }
}