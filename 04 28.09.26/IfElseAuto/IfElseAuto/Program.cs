namespace IfElseAuto
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Wasup motherfucker! Mis autod soovid?");
            string input = Console.ReadLine();
            if (input == "skoda")
            {
                Console.WriteLine("milline mudel?");
                string skoda = Console.ReadLine();
                if (skoda == "octavia")
                {
                    Console.WriteLine("good choice, good car");
                }
                else if (skoda == "kodiaq")
                {
                    Console.WriteLine("bad choice, good car");
                }
                else
                {
                    Console.WriteLine("HA, idikas. Sellist mudelit me ei müü!");
                }
            }
            else if (input == "bmw")
            {
                Console.WriteLine("milline mudel?");
                string bmw = Console.ReadLine();
                if (bmw == "M6")
                {
                    Console.WriteLine("good choice, bad car");
                }
                else if (bmw == "M8")
                {
                    Console.WriteLine("bad choice, bad car");
                }
                else
                {
                    Console.WriteLine("HA, idikas. Sellist mudelit me ei müü!");
                }
            }
            else if (input == "audi")
            {
                Console.WriteLine("milline mudel?");
                string audi = Console.ReadLine();
                if (audi == "Q8")
                {
                    Console.WriteLine("good choice, bad car");
                }
                else if (audi == "e-tron")
                {
                    Console.WriteLine("good choice, good car");
                }
                else
                {
                    Console.WriteLine("HA, idikas. Sellist mudelit me ei müü!");
                }
            }
            else if (input == "porsche")
            {
                Console.WriteLine("milline mudel?");
                string porsche = Console.ReadLine();
                if (porsche == "911")
                {
                    Console.WriteLine("good choice, good car");
                }
                else if (porsche == "718")
                {
                    Console.WriteLine("bad choice, bad car");
                }
                else
                {
                    Console.WriteLine("HA, idikas. Sellist mudelit me ei müü!");
                }
            }
            else
            {
               Console.WriteLine("HA, idikas. Sellist autod me ei müü!");
            }
        }
    }
}