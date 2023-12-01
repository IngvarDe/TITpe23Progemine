namespace WeekdayName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //sulgudesse tuleb sisestada t'nane p'ev
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("T'na on esmasp'ev");
                    break;

                case DayOfWeek.Tuesday:
                    Console.WriteLine("T'na on teisip'ev");
                    break;

                case DayOfWeek.Wednesday:
                    Console.WriteLine("T'na on kolmap'ev");
                    break;

                case DayOfWeek.Thursday:
                    Console.WriteLine("T'na on neljap'ev");
                    break;

                case DayOfWeek.Friday:
                    Console.WriteLine("T'na on reede");
                    break;

                default:
                    break;
            }
        }
    }
}