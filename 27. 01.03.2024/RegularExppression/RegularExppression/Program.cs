using System.Text.RegularExpressions;


namespace RegularExppression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "#CD5C5C";
            Console.WriteLine("Hex code: " + word);
            Console.WriteLine("Kas on regex: " + RegExTest(word));

            //tee regex, mis on falsetulemusega
            //põhjenda ära, et miks on false
        }
        public static bool RegExTest(string word)
        {
            return Regex.IsMatch(word, @"[#][0-9A-Fa-f]{6}\b");
        }
    }
}