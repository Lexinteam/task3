using System;
using System.Collections.Generic;
using System.Linq;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc calc1 = new Calc();

            calc1.ShowResult();
        }



        class Calc
        {

            private int number1;
            private int number2;
            private bool valid1 = false;
            private bool valid2 = false;
            private int[] array1;
            private int[] arrayForSum;
            private int finalSum;

            public Calc()
            {
                Console.WriteLine("Please enter range of natural numbers. Range should contain at least 10 natural numbers");
                Console.WriteLine("First number?");

                while (valid1 == false)
                {
                    string Input = Console.ReadLine();
                    if (int.TryParse(Input, out number1))
                    {
                        valid1 = true;
                    }
                    else
                    {
                        Console.WriteLine("Not an integer, please try again.");
                    }
                }

                Console.WriteLine("Second number?");

                while (valid2 == false)
                {
                    string Input = Console.ReadLine();
                    if (int.TryParse(Input, out number2) && ((number2 - number1) >= 10))
                    {
                        valid2 = true;
                    }
                    else
                    {
                        Console.WriteLine("Not an integer, or range is less than 10 please try again.");
                    }
                }

                array1 = Enumerable.Range(number1, number2).ToArray();
            }


            public void ShowResult()
            {
                // any way without using lists?
                var list = new List<int>();
                foreach (int i in array1)
                {
                    if ((i % 3 == 0) && (i % 5 != 0)) list.Add(i);
                }
                arrayForSum = list.ToArray();

                finalSum = arrayForSum.Sum();


                Console.WriteLine($"Sum of numbers: {finalSum}");

            }
        }
    }
}
