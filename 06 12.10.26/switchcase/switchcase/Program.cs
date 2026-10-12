namespace switchcase
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("sisesta info");
            string input = Console.ReadLine();

            switch (input)
            {
                case "a":
                    Console.WriteLine("sisestasid vokaali a");
                    break;
                case "e":
                    Console.WriteLine("sisestatud vokaali e");
                    break;
                case "i":
                    Console.WriteLine("sisestasid vokaali i");
                    break;
                default:
                    Console.WriteLine("sisestatud vokaal ei ole täht");
                    break;
            }
        }
    }
}