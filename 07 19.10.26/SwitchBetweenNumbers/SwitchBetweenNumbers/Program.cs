namespace SwitchBetweenNumbers
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");

            string number = Console.ReadLine();
            int input = int.Parse(s: number);

            switch (input)
            {
                case >= 0 and <= 100:
                    Console.WriteLine("low number " + input);
                    break;
                case >= 101 and <= 200:
                    Console.WriteLine("medium number " + input);
                    break;
                case >= 201 and <= 300:
                    Console.WriteLine("hig number " + input);
                    break;
                default:
                    Console.WriteLine("shit knows what is this number " + input);
                    break;
            }
        }
    }
}