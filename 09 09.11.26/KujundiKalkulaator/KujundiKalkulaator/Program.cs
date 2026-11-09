namespace KujundiKalkulaator
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine();

            double roundRadius = 3;
            double diameter = roundRadius * 2;

            double squareArea1 = Math.Pow(diameter, 2);
            double squareArea2 = diameter * diameter;
            double squarePerimeter = diameter * 4;

            double roundArea1 = Math.PI * Math.Pow(roundRadius, 2);
            double roundArea2 = Math.PI * (roundRadius * roundRadius);
            double roundPerimeter = 2 * Math.PI * roundRadius;

            string tulemus1 = squarePerimeter.ToString("0.##");
            string tulemus2 = roundPerimeter.ToString("0.##");

            Console.WriteLine("POV: Ruudu pindala on " + Math.Round(squareArea2, 2));
            Console.WriteLine("POV: Ruudu ümbermõõt on " + tulemus1);
            Console.WriteLine();
            Console.WriteLine("POV: Ringi pindala on " + Math.Round(roundArea1, 2));
            Console.WriteLine("POV: Ringi ümbermõõt on " + tulemus2);
        }
    }
}