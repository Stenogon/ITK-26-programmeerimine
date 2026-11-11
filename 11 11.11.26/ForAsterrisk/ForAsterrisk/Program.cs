namespace ForAsterrisk
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");

            int nr = int.Parse(Console.ReadLine());

            for (int i = 0; i < nr; i++)
            {
                Console.WriteLine("*");
                Console.WriteLine(361 * 2);
            }
        }
    }
}