namespace KujundiKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kujundi kalkulaator");
            //Ruudu sees asub ring. Ringi raadius on 3.
            //Leia ja väljasta ekraanile ruudu pindala ja ümbermõõt.

            int roundRadius = 3;
            //int roundDiameter = 6;

            Console.WriteLine("Ruudu pindala: " + (2 * roundRadius) * (2 * roundRadius));
            Console.WriteLine("Ruudu ümbermõõt: " + (2 * roundRadius) * 4);

            //Leia ja väljasta ekraanile ringi pindala ja ümbermõõt.
            Console.WriteLine("Ringi  pindala: " + Math.PI * (roundRadius * roundRadius));
            Console.WriteLine("Ringi ümbermõõt: " + 2 * Math.PI * roundRadius);
        }
    }
}