using System;

    class NumbersNotDivisibleBy3And7
    {
        static void Main()
        {
            Console.Write("Enter a positive integer number : ");
            uint number = uint.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    continue;
                }
                Console.Write(i+" ");
            }
            Console.WriteLine();
        }
    }

