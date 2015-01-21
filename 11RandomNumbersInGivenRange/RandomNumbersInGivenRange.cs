using System;

    class RandomNumbersInGivenRange
    {
        static void Main()
        {
            Console.WriteLine("Enter 3 integers n, min and max -->(min ≤ max) ");
            Console.Write("Enter n : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter min : ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Enter max : ");
            int max = int.Parse(Console.ReadLine());

            if (min > max)
            {
                Console.WriteLine("Inavalid input ! Max should be bigger or equal to min!!! ");
                return;
            }
            Random rnd = new Random();
            for (int i = 1; i <= n; i++)
            {
                int randomNum = rnd.Next(min, max + 1);
                Console.Write("Random numbers - {0} ", randomNum);
            }
            Console.WriteLine();
        }
    }

