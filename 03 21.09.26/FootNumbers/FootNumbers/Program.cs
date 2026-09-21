namespace FootNumbers
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            int foot = int.Parse(input);

            if (foot <= 38)
            {
                if (foot >= 30 && foot <= 33)
                {
                    Console.WriteLine("roheline");
                }
                else if (foot >= 34 && foot <= 38)
                {
                    Console.WriteLine("valge");
                }
                else
                {
                    Console.WriteLine("tundmatu number");
                }
            }
            else if (foot >= 39)
            {
                if (foot >= 39 && foot <= 44)
                {
                    Console.WriteLine("kollane");
                }
                else if (foot >= 45 && foot <= 48)
                {
                    Console.WriteLine("beep");
                }
                else
                {
                    Console.WriteLine("tundmatu number");
                }
            }
        }
    }
}