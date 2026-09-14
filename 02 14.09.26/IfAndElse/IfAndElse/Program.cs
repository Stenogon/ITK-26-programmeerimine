namespace IfAndElse
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("sisesta enda nimi");

            //siin on muutuja nimega namer, mis on tüübiga string loeb andmeid konsoolist ja salvestab need muutuja namer sisse
            string namer = Console.ReadLine();

            //kui muutuja name on tühi, siis väljustab konsoolile
            if (namer != "")
            {
                Console.WriteLine(namer + " on meie tänane pede!");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Tere tere vanakere, mingu perse vana pede!");
            }
        }
    }
}