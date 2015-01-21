using System;

    class Calculate
    {
        static void Main()
        {
            Console.Write("Enter n : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter x : ");
            int x = int.Parse(Console.ReadLine());
            double fact = 1;
            double multyX = 1;
            double sum = 1;

            for (int i = 1; i <= n; i++)
            {
                fact *= i;
                multyX *= x;
                sum += fact / multyX;
            }
            Console.WriteLine("The sum is = {0:0.00000}",sum);
        }
    }

