namespace DictionaryForeach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dictionary ja foreach");

            var domains = new Dictionary<string, string>()
            {
                {"est", "Estonia" },
                {"lat", "Latvia" },
                {"fin", "Finland" },
                {"swe", "Sweden" }
            };
            //kasutate foreachi ja juurde tuleb kolmas rida
            int i = 1;
            foreach (var pair in domains)
            {
                Console.WriteLine($"{pair.Key} - {pair.Value} - {i}");
                i++;
            }
            //see kood githubi panna
        }
    }
}