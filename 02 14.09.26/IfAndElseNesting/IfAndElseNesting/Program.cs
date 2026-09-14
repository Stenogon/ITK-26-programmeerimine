namespace IfAndElseNesting
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");

            double y = 9.0;

            if (y == 9)
            {
                if (y == 11)
                {
                    Console.WriteLine("Vastus on 11");
                }
                else
                {
                    Console.WriteLine("Vastus on kõik peale 11");
                }
            }
            else if (y == 12)
            {
                Console.WriteLine("vastus on 20.5");
            }
            else if (y == 30)
            {
                Console.WriteLine("vastus on 30");
            }
            else
            {
                Console.WriteLine("mingi kahtlane number");
            }
        }
    }
}