namespace random
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");

            int input = new Random().Next(1, 7);

            Console.WriteLine(input);

            switch (input)
            {
                case 1:
                    Console.WriteLine("you are 1");
                    break;
                case 2:
                    Console.WriteLine("you are 2");
                    break;
                case 3:
                    Console.WriteLine("you are 3");
                    break;
                case 4:
                    Console.WriteLine("you are 4");
                    break;
                case 5:
                    Console.WriteLine("you are 5");
                    break;
                case 6:
                    Console.WriteLine("you are 6");
                    break;
                case 7:
                    Console.WriteLine("you are 7");
                    break;
            }
        }
    }
}
