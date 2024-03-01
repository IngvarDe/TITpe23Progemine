namespace ArraySortNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] animals = {"cat", "alligator", "fox",
            "donkey", "bear", "elephant", "goat"};

            //tuleb kasutada Sort ja mingit loopi
            //Array.Sort(animals);
            foreach (string animal in animals)
            {
                Console.WriteLine(animal);
            }
            Console.WriteLine("-----------------------");
            //j'rjesta kolm esimest sõna tähestikulises järjestuses
            //vaadake Sort meetodit ja mitu overload sel on

            Array.Sort(animals, 0, 3);
            foreach (string animal in animals)
            {
                Console.WriteLine(animal);
            }

            Console.WriteLine("-----------------------");
            int[] numbers = { 1, 2, 3, 4, 3, 55, 23, 2 };
            //tuleb välistada kordused

            int[] distinct = numbers.Distinct().ToArray();
            foreach (int number in distinct)
            {
                Console.WriteLine(number);
            }    
        }
    }
}