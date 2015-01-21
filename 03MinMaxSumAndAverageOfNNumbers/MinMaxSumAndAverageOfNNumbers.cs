using System;

    class MinMaxSumAndAverageOfNNumbers
    {
        static void Main()
        {
            Console.Write("Enter how many number you will enter : ");
            int n = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int max = int.MinValue;
            double sum = 0;
            double avg = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                min = Math.Min(min, number);
                max = Math.Max(max, number);
                sum += number;
                avg = sum / n;
            }
            Console.WriteLine("min = "+min);
            Console.WriteLine("max = " + max);
            Console.WriteLine("sum = {0:##}",sum );
            Console.WriteLine("avg = {0:0.00}",avg);
        }
    }

