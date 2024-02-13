namespace ForLoopTwoPyramids
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, r;  // Declaration of variables i, j, and r as integers

            Console.Write("\n\n");  // Displaying new lines
            Console.Write("Peegelpildis olev püramiid:\n");  // Displaying the purpose of the program
            Console.Write("-----------------------------------");  // Displaying a separator
            Console.Write("\n\n");  // Displaying new lines

            Console.Write("Sisesta suurus: ");  // Prompting the user to input the number of rows
            r = Convert.ToInt32(Console.ReadLine());  // Reading the number of rows entered by the user



            // Loop to print the lower part of the diamond pattern
            for (i = r - 1; i >= 1; i--)
            {
                for (j = 1; j <= r - i; j++)
                {
                    Console.Write(" ");
                }
                      // Printing spaces before the asterisks

                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");  // Printing asterisks to form the lower part of the diamond
                }

                Console.Write("\n");  // Moving to the next line after each row
            }

            // Loop to print the upper part of the diamond pattern
            for (i = 0; i <= r; i++)
            {
                for (j = 1; j <= r - i; j++)
                {
                    Console.Write(" ");  // Printing spaces before the asterisks
                }

                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");  // Printing asterisks to form the upper part of the diamond
                }

                Console.Write("\n");  // Moving to the next line after each row
            }
        }
    }
}