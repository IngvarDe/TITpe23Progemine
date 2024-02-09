namespace ForeachMethodCall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Punktide panek");
            int[] marks = { 125, 132, 95, 116, 110 };

            int highestMarks = Maximum(marks);

            Console.WriteLine("The highest score is " + highestMarks);
        }

        public static int Maximum(int[] numbers)
        {
            int maxNumbers = numbers[0];

            foreach (int number in numbers)
            {
                if (number > maxNumbers)
                {
                    maxNumbers = number;
                }
            }

            return maxNumbers;
        }
    }
}