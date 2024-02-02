namespace ForeachDivider
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] genders = { "m", "f", "m", "m", "m", "f", "f", "m", "m", "f" };

            int female = 0, male = 0;

            foreach (string gender in genders)
            {
                //läbi foreachi kontrollib ära, et
                //mitu meest ja naist saab kokku
                //if (gender == "m")
                //{
                //    male++;
                //}
                //if (gender == "f")
                //{
                //    female++;
                //}
                //kasutada lühikest if ja else e short if and else e ternary operator
                var result = gender == "f" ? female++ : male++;
            }

            Console.WriteLine("Number of female = {0} and nr of male {1}", female, male);
        }
    }
}