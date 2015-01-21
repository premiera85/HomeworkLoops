using System;

    class NumbersFrom1ToN
    {
        static void Main()
        {
            Console.Write("Enter a positive integer number : ");
            uint number = uint.Parse(Console.ReadLine());
            int n = 1;
            while (n <= number)
            {
                Console.Write(n+" ");
                n++;
            }
        }
    }

