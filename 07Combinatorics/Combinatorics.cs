using System;
using System.Numerics;

    class Combinatorics
    {
        static void Main()
        {
            Console.WriteLine("Enter N and K ,(1 < k < n < 100)  ");
            Console.Write("Enter n : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter k : ");
            int k = int.Parse(Console.ReadLine());
            BigInteger factN = 1;
            BigInteger factK = 1;
            BigInteger diffFact = 1;
            BigInteger result = 0;

            if (1 < k && k < n && n < 100)
            {
                for (int i = 1; i <= n; i++)
                {
                    factN *= i;
                    if (i <= k)
                    {
                        factK *= i;
                    }
                }
                for (int i = 1; i <= n-k; i++)
                {
                    diffFact *= i;
                }
                result = factN / (factK * diffFact);
                Console.WriteLine("N! / (K! * (N-K)!) = " + result);
            }
            else 
            {
                Console.WriteLine("Please enter n and k (1 < k < n < 100) ");

            }
        }
    }

