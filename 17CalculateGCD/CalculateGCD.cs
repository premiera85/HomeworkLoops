using System;

    class CalculateGCD
    {
        static void Main()
        {
            Console.Write("Enter a : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b : ");
            int b = int.Parse(Console.ReadLine());

            while (b != 0)
            {
                int temp;
                temp = b;
                b = a % b;
                a = temp;
            }
            Console.WriteLine("GDC: {0}", a);
        }
    }

