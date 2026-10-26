namespace WhileDo
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");

            int input = int.Parse(Console.ReadLine());
            int i = 1;

            do
            {
                Console.WriteLine(i);
                i++;
                Thread.Sleep(1000);
            } while (i <= input);
        }
    }
}