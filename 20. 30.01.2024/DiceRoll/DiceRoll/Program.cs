﻿namespace DiceRoll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var values = new List<object>();
            for (int ctr = 0; ctr <= 7; ctr++)
            {
                if (ctr == 2) 
                { 
                    values.Add(DiceLibrary.Roll2()); 
                }
                else if (ctr == 4)
                {
                    values.Add(DiceLibrary.Pass());
                }
                else
                {
                    values.Add(DiceLibrary.Roll());
                }
            }

            Console.WriteLine($"The sum of {values.Count} die is" +
                $" {DiceLibrary.DiceSum(values) }!");
        }
    }

    public static class DiceLibrary
    {
        //Random number generator to simulate dice rolls
        static Random rnd = new Random();

        //Roll a single die
        public static int Roll()
        {
            return rnd.Next(1, 7);
        }

        //Roll two dice
        public static List<object> Roll2()
        {
            var rolls = new List<object>();
            rolls.Add(Roll());
            rolls.Add(Roll());
            return rolls;
        }

        //Calculate the sum of n dice rolls
        public static int DiceSum(IEnumerable<object> values)
        {
            var sum = 0;

            foreach (var item in values)
            {
                switch (item) 
                {
                    //a single zero value
                    case 0:
                        break;

                    //a single value
                    case int val:
                        sum += val;
                        break;

                    //a non-empty collection
                    case IEnumerable<object> subList when subList.Any():
                        sum += DiceSum(subList);
                        break;

                    //an empty collection
                    case IEnumerable<object> sublist:
                        break;

                    //a null reference
                    case null:
                        break;

                    default:
                        throw new InvalidOperationException("unknown item type");
                }
            }

            return sum;
        }

        public static object Pass()
        {
            if (rnd.Next(0, 2) == 0)
            {
                return null;
            }
            else
            {
                return new List<object>();
            }
        }
    }
}