using System;
using System.Numerics;

    class TrailingZeroesInN
    {
        static void Main()
        {
            Console.Write("Enter a number : ");
            int number = int.Parse(Console.ReadLine());
            BigInteger factNum = 1;
            int trailingZ = 0;
            for (int i = 1; i <= number; i++)
            {
                factNum *= i;
            }
            Console.WriteLine("Explaination - n! = " + factNum);
            while (factNum%10== 0)
            {
                factNum  /= 10;
                trailingZ++;
            }
            Console.WriteLine("Trailing Zeroes = "+trailingZ);
            
        }
    }

