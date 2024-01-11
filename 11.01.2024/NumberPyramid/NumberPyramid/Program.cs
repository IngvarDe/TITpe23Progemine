namespace NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, rows;
            int t = 0;
            Console.WriteLine("Numbri püramiid");

            Console.WriteLine("Sisesta ridade arv");

            rows = Convert.ToInt32(Console.ReadLine());


            for (i = 0; i <= rows; i++)
            {
                for (j = 1; j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("{0} ", t++);
                    //Console.Write("*"); //kui paned selle, siis saad püramiidi
                }
                Console.Write("\n");
            }
        }
    }
}