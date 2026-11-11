using System.Drawing;

namespace ForLoopEndless
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");

            ushort counter = 1;
            for (; ; )
            {
                Console.WriteLine(counter);
                counter++;

                if (counter > 10)
                {
                    break;
                }
            }
        }
    }
}