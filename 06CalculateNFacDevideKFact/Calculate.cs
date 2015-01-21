using System;
using System.Numerics;

    class Calculate
    {
        static void Main()
        {
            Console.WriteLine("Enter N and K ,(1 < k < n < 100)  ");
            Console.Write("Enter n : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter k : ");
            int k = int.Parse(Console.ReadLine());
            BigInteger result = 1;
            if (1 < k && k < n && n < 100)
            {
                for (int i = k + 1; i <= n; i++)
                {
                    result *= i;

                }
                Console.Write("N!/K! = " + result);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Please enter n and k (1 < k < n < 100) ");
            }
        }
    }

