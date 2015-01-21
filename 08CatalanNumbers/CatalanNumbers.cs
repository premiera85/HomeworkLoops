using System;
using System.Numerics;

namespace  System.Numerics
{
    class CatalanNumbers
    {
            static void Main()
            {
                Console.WriteLine("Enter N as (1 < n < 100)  ");
                Console.Write("Enter n : ");
                int n = int.Parse(Console.ReadLine());
                BigInteger factN = 1;
                BigInteger factTwoTimesN = 1;
                BigInteger factNPlusOne = 1;
                BigInteger result = 0;
                if (n==0)
                {
                    Console.WriteLine("CatalanNumbers(n) = 1");
                }
                else if (n > 1 && n < 100)
                {
                    for (int i = 1; i <= n; i++)
                    {
                        factN *= i;
                    }
                    for (int i = 1; i <= 2*n; i++)
                    {
                        factTwoTimesN *= i;
                    }
                    for (int i = 1; i <= n+1; i++)
                    {
                        factNPlusOne *= i;
                    }
                    result = factTwoTimesN / (factNPlusOne * factN);
                    Console.WriteLine("Catalan number = "+ result);
                }
                else
                {
                    Console.WriteLine("Input out of range (1 < n < 100) !!!");
                }
            }
    }
}
