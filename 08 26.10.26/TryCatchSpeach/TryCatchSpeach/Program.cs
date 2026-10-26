namespace TryCatchSpeach
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");

            try
            {
                int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.WriteLine("valisid 1");
                        break;
                    case 2:
                        Console.WriteLine("valisid 2");
                        break;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("palun sisesta number");
            }
            catch
            {
                Console.WriteLine("number on liiga suur");
            }
        }
    }
}