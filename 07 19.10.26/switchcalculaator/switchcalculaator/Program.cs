namespace switchcalculaator
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("sisesta number");
            float üks = float.Parse(Console.ReadLine());

            Console.WriteLine("sisesta tehe +,-,*,/");
            string input = Console.ReadLine();

            Console.WriteLine("sisesta teine number");
            float kaks = float.Parse(Console.ReadLine());

            switch (input)
            {
                case "+":
                    Console.WriteLine(üks + kaks);
                    break;
                case "-":
                    Console.WriteLine(üks - kaks);
                    break;
                case "*":
                    Console.WriteLine(üks * kaks);
                    break;
                case "/":
                    if (kaks == 0)
                    {
                        Console.WriteLine("nulliga jagada ei saa");
                    }
                    else
                    {
                        Console.WriteLine(üks + kaks);
                    }
                    break;
            }
        }
    }
}