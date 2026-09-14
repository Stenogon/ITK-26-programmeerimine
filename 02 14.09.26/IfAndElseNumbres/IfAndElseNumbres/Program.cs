namespace IfAndElseNumbres
{
    internal class Program
    {
        static void Main()
        {
            { }
            Console.WriteLine("kirjuta enda vanust");

            string input = Console.ReadLine();
            int age = int.Parse(input);

            if (age >= 18)
            {
                Console.WriteLine("sa oled juba vana mutt");
            }
            else
            {
                Console.WriteLine("Sa oled veel noor mutt");
            }
        }
    }
}