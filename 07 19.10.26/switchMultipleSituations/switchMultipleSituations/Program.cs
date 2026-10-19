namespace switchMultipleSituations
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");

            string input = Console.ReadLine();

            switch (input)
            {
                case "intro to c#" or "variablse" or "data types":
                    Console.WriteLine("basic");
                    break;
                case "oop" or "classes" or "ojects":
                    Console.WriteLine("intermediate");
                    break;
                case "asymcronus" or "linq" or "delegates":
                    Console.WriteLine("advenced");
                    break;
                default:
                    Console.WriteLine("wtf is that??");
                    break;
            }
        }
    }
}