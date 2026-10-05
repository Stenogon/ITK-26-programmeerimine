namespace ifelseask_name
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("who the hell are you?"); 
            string input = Console.ReadLine();

            if (input == "george")
            {
                Console.WriteLine("wasup George");
            }
            else
            {
                Console.WriteLine("idk who are you!");
            }
        }
    }
}