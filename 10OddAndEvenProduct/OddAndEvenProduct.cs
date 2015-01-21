using System;

    class OddAndEvenProduct
    {
        static void Main()
        {
            Console.Write("Enter your integers in a single line, separated by a space : ");
            string[] num = Console.ReadLine().Split();
            int prodOdd = 1;
            int prodEven = 1;

            for (int i = 0; i < num.Length; i++)
            {
                if (i % 2 == 0)
                {
                    prodOdd *= Convert.ToInt32(num[i]);
                }
                else
                {
                    prodEven *= Convert.ToInt32(num[i]);
                }
            }
            if (prodOdd == prodEven)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("product = "+prodEven);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Odd product = {0} , Even product = {1} ",prodOdd,prodEven);
            }
        }
    }

