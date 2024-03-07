using System.Collections.Generic;

namespace SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorted List");

            SortedList<int, string> numberNames = new SortedList<int, string>();

            numberNames.Add(3, "Three");
            numberNames.Add(1, "One");
            numberNames.Add(2, "Two");
            numberNames.Add(4, null);
            numberNames.Add(10, "Ten");
            numberNames.Add(5, "Five");

            foreach (var kvp in numberNames)
            {
                Console.WriteLine("Key: {0}, Value:{1}", kvp.Key, kvp.Value);
            }
            Console.WriteLine("--------------------------------------");
            foreach (KeyValuePair<int, string> a in numberNames) 
            {
                Console.WriteLine("Key: {0}, Value:{1}", a.Key, a.Value);
            }
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Numbrite eemaldamine");
            SortedList<int, string> keyValuePairs = new SortedList<int, string>()
            {
                {3, "Three" },
                {1, "One"},
                {2, "Two"},
                {5, "Five"},
                {4, "Four"},
            };

            keyValuePairs.Remove(2);//mida tegi see???
            keyValuePairs.RemoveAt(0);//mida tegi see???
            //eemaldab elemendi ja järelejäänud asjad nimekirjas
            //järjestatakse ümber

            foreach (var kvp in keyValuePairs)
            {
                Console.WriteLine("Key: {0}, Value:{1}", kvp.Key, kvp.Value);
            }
        }
    }
}