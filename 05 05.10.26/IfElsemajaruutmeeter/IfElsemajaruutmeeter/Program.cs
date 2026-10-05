namespace IfElsemajaruutmeeter
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");
            
            Console.WriteLine("mis on sinu maja ruudustik?");

            string number = Console.ReadLine();
            int input = int.Parse(number);

            if (input >= 0 && input <= 40)
            {
                Console.Write("sinu maja ruutmeetrid on "); Console.Write(input); Console.Write("m2");
            }
            else if (input >= 41 && input <= 90)
            {
                Console.Write("sinu maja ruutmeetrid on "); Console.Write(input); Console.Write("m2");
            }
            else if (input >= 91 && input <= 130)
            {
                Console.Write("sinu maja ruutmeetrid on "); Console.Write(input); Console.Write("m2");
            }
            else
            {
                Console.Write("sinu maja ruutmeetrid on "); Console.Write(input); Console.Write("m2?");
            }
        }
    }
}