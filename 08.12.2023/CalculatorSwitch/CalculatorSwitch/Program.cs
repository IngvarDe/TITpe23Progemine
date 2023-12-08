namespace CalculatorSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalkulaator");

            //vaja sisestada nr konsooli ja 
            //muudab selle int andmetüübiks
            Console.WriteLine("Sisesta esimene nr");
            float firstNr = float.Parse(Console.ReadLine());

            Console.WriteLine("Sisesta tehe");
            string op = Console.ReadLine();

            Console.WriteLine("Sisesta teine nr");
            float secondNr = float.Parse(Console.ReadLine());

            switch (op)
            {
                case "+":
                    Add(firstNr, secondNr);
                    break;

                case "-":
                    Subtract(firstNr, secondNr);
                    break;

                case "*":
                    Multiple(firstNr, secondNr);
                    break;

                case "/":
                    Divide(firstNr, secondNr);
                    break;
            }

        }

        static void Add(float firstNr, float secondNr)
        {
            float resultAdd = firstNr + secondNr;
            Console.WriteLine("Tulemus: " + resultAdd);
        }

        static void Subtract(float firstNr, float secondNr)
        {
            float resultAdd = firstNr - secondNr;
            Console.WriteLine("Tulemus: " + resultAdd);
        }

        static void Multiple(float firstNr, float secondNr)
        {
            float resultAdd = firstNr * secondNr;
            Console.WriteLine("Tulemus: " + resultAdd);
        }

        static void Divide(float firstNr, float secondNr)
        {
            float resultAdd = firstNr / secondNr;
            Console.WriteLine("Tulemus: " + resultAdd);
        }
    }
}