namespace WhileNesting
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");

            int a = 1;
            while (a <=5)
            {
                int b = 1;
                while(b <= 5)
                {
                    Console.WriteLine("*");
                    b++;
                }
                Console.WriteLine("hi");
                a++;
            }
        }
    }
}