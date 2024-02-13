namespace ForLoopArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array e jada e massiiv");

            //loome massiivi
            int[] array = new int[5];

            //massiivi kasutamine
            array[0] = 10;
            array[2] = 20;
            array[4] = 30;

            //massiiv käib kõik numbrid läbi, kasutad for loopi
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}