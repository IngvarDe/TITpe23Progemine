namespace OddNumberForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] oddArray = new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };

            //foreach (int num in oddArray)
            //{
            //    Console.WriteLine(num);

            //    if (num == 13)
            //    {
            //        break;
            //    }
            //}
            //teha sama asi for loopiga
            for (int i = 1; i < 99; i++)
            {
                if (i <= 14)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i.ToString());
                    }
                }
            }
        }
    }
}