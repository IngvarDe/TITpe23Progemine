namespace ListNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Massiiv e Array");

            int[] numbers = { 2, 4, 6, 8, 10 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("----------------------");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i] + 10);
            }

        }
    }
}