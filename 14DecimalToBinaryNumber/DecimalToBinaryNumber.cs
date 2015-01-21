using System;

    class DecimalToBinaryNumber
    {
        static void Main()
        {
            Console.Write("Enter a integer number : ");
            long decimalNum = long.Parse(Console.ReadLine());
            string binary = "";
            if (decimalNum > 0)
            {
                while (decimalNum >= 1)
                {
                    binary = (decimalNum % 2) + binary;
                    decimalNum = decimalNum / 2;
                }
                Console.WriteLine("The binary is " + binary);
            }
            else if (decimalNum == 0)
            {
                Console.WriteLine("The binary is  0 ");
            }
            
        }
    }

