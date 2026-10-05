namespace IfElseautomotor
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("what is youre engine power?");

            string number = Console.ReadLine();
            int input = int.Parse(number);

            if (input >= 0 && input <= 100)
            {
                Console.Write("sinu auto mootori võimsus on "); Console.Write(input); Console.Write("hj");
            }
            else if (input >= 101 && input <= 150)
            {
                Console.Write("sinu auto mootori võimsus on "); Console.Write(input); Console.Write("hj");
            }
            else if (input >= 151 && input <= 250)
            {
                Console.Write("sinu auto mootori võimsus on "); Console.Write(input); Console.Write("hj");
            }
            else
            {
                Console.Write("sinu auto mootori võimsus on "); Console.Write(input); Console.Write("hj");
            }
        }
    }
}