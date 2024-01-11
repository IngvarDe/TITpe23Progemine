namespace MultipleCases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiple Cases");

            string topic, category;

            topic = "Inheritance";

            switch (topic)
            {
                case "Intro to C#":
                case "Variables":
                case "Data Types":

                    category = "Basic";
                    break;


                case "Loops":
                case "If statements":
                case "Jump Statements":

                    category = "Control Flow";
                    break;

                case "Class & Objects":
                case "Inheritance":
                case "Constructors":

                    category = "OOP-s Concept";
                    break;

                default:
                    category = "UNKNOWN";
                    break;
            }
            Console.WriteLine("Category is " + category);
        }
    }
}