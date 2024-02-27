namespace ListNumbersMinMaxSumAvarage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5] { 10, 15, 16, 8, 6 };

            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Sum());
            Console.WriteLine(numbers.Average());

            Console.WriteLine("------------------------");
            Console.WriteLine("Sorteerib numbrid alates v'iksemat suuremani");

            //Array.Clear(numbers);
            Array.Sort(numbers);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Sorteerib numbrid alates suureamst väiksemani");
            Array.Reverse(numbers);
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("--------------------------");
            Console.WriteLine(Array.BinarySearch(numbers, 15));
            //Kirjutada, et mida BinarySearch tähendab
        }
    }
}