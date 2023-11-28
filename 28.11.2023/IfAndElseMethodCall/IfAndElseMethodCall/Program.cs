namespace IfAndElseMethodCall
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Main meetodi algus");

            //kutsume esile teise meetodi
            Main1();

            Console.WriteLine("Lõpp");
        }

        static void Main1()
        {
            Console.WriteLine("Main1 meetod tekst");
        }
    }
}