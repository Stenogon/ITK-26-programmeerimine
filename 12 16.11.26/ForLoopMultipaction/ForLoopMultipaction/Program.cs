namespace ForLoopMultipaction
{
    internal class Program
    {
        static void Main()
        {
            {
                Console.WriteLine("Korrutustabel");

                int j, i, n;

                Console.WriteLine("Sisesta tabelisse number, mis on viimane korrutis");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Korrutustabel ühest kuni {0}", n);
                Console.WriteLine("\n");

                for (i = 1; i <= 10; i++)
                {
                    for (j = 1; j <= n; j++)
                    {
                        if (j <= n - i)
                        {
                            Console.Write("{0}*{1} = {2}, ", j, i, i * j);
                        }
                        else
                        {
                            Console.Write("{0}*{1} = {2}, ", j, i, i * j);
                        }
                    }
                    Console.Write("\n");
                }
            }

        }
    }
}