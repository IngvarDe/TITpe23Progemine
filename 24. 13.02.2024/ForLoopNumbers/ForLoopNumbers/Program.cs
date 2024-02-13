namespace ForLoopNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Kui kirjutan kolmnurga suuruse,
            //siis viie puhul on tulemus selline:

            //1
            //22
            //333
            //4444
            //55555

            int i, j, rows;
            Console.WriteLine("Sisesta ridade number");
            rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\n");

            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }

                Console.Write("\n");
            }
        }
    }
}