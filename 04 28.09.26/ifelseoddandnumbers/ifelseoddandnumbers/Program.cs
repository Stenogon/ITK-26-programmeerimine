namespace ifelseoddandnumbers
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");

            string number = Console.ReadLine();
            int input = int.Parse(number);

            if (input % 2 == 0)
            {
                paaris();

            }
            else
            {
                paaritu();
            }
        }
        static void paaris()
        {
            Console.WriteLine("paaris arv");
        }
        static void paaritu()
        {
            Console.WriteLine("paaritu arv");
        }
    }
}