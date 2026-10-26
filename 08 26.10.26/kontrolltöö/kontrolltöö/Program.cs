namespace kontrolltöö
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("sisesta number");
            float üks = float.Parse(Console.ReadLine());

            Console.WriteLine("sisesta teine number");
            float kaks = float.Parse(Console.ReadLine());

            switch (üks * kaks)
            {
                case >0:
                    Console.WriteLine("vastus on");
                    Console.WriteLine(üks * kaks);
                    break;
                case 0:
                    Console.WriteLine("korrutamine on võimatu");
                    break;
            }

            Console.WriteLine("------------------------------");

            Console.WriteLine("mis on teie vanus?");
            int vanus = int.Parse(Console.ReadLine());

            switch (vanus)
            {
                case > 18:
                    Console.WriteLine("sa oled vana ja sinu vanus on " + vanus);
                    break;
                case < 19:
                    Console.WriteLine("sa oled noor ja sinu vanus on " + vanus);
                    break;
            }

            Console.WriteLine("------------------------------");

            Console.WriteLine("ütelge salasõna");
            string sõna = Console.ReadLine();

            switch (sõna)
            {
                case "miau":
                    Console.WriteLine("teretulemast tiimi");
                    break;
                default:
                    Console.WriteLine("ligipääs on keelatud");
                    break;
            }
        }
    }
}