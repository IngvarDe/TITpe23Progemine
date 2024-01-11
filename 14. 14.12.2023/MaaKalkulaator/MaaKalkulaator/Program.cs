namespace MaaKalkulaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maa kalkulaator");
            //Meil on münt, mille diameeter on 25.75 mm
            //Arvutada välja Maa ümbermõõt ja mitu münti 
            //Mahub järjestikku ümber Maa
            //Arvutuses tohib kasutada ainult mündi diameetrit ja Maa raadiust

            double coinDiameter = 25.75; //mm
            double earthRadius = 6378100000;
            double aroundEarth = 2 * Math.PI * earthRadius;

            Console.WriteLine(aroundEarth);
            double howManyCoins = aroundEarth / coinDiameter;

            Console.WriteLine("kahe euroste arv ümber maa {0}", howManyCoins);
        }
    }
}