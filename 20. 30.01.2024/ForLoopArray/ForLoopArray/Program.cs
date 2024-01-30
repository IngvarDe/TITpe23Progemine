namespace ForLoopArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] myArray = { "H", "e", "l", "l", "o" };

            //vaja for loopiga iga täht konsooli saada
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}