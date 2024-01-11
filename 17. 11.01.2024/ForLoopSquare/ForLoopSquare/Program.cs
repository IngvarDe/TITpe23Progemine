using System;

namespace ForLoopSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ruut");
            Console.WriteLine("Sisesta ruudu suurus");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine("Ruudu pindala ja ümbermõõt:");
            //Ruudu pindala on ... ja ümbermmõõt on ...
            Console.WriteLine("Ruudu pindala on " + size * size + 
                " ja ümbermmõõt on " + size * 4 + " ühikut");

            for (int row = 1; row <= size; row++)
            {
                for (int column = 1; column <= size * 2; column++)
                {
                    string mark;
                    if (row == column || row + column <= size + 1)
                    {
                        mark = "*";
                    }
                    else
                    {
                        mark = "*";
                    }
                    Console.Write(mark);
                }
                Console.WriteLine();
            }
        }
    }
}