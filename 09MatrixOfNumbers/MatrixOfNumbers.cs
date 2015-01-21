using System;

    class MatrixOfNumbers
    {
        static void Main()
        {
            Console.Write("Enter a positive integer number N --> (1 ≤ n ≤ 20) : ");
            string consoleInput = Console.ReadLine();
            int n = int.Parse(consoleInput);
            Console.WriteLine();

            if (n >= 1 && n <= 20)
            {
                for (int row = 1; row <= n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        Console.Write(row + col+" ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid input -->N --> (1 ≤ n ≤ 20)");
            }
        }
    }

