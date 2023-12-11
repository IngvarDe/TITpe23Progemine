namespace WhileDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While ja Do");

            int number = 1;

            do 
            { 
                Console.WriteLine(number);
                number++; 
            } 
            while (number <= 5);

        }
    }
}