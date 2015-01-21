using System;

    class BinaryToDecimalNumber
    {
        static void Main()
        {
            Console.Write("Enter a binary integer : ");
            string binary = Console.ReadLine();
            long decimalNum;
            System.Text.RegularExpressions.Regex r = new System.Text.RegularExpressions.Regex("^[0-1]+$");
            while (r.Match(binary).Success)
            {
                decimalNum = Convert.ToInt32(binary, 2);
                Console.Write("The decimal number is = {0} ", decimalNum);
                break;
            }
            Console.WriteLine();
        }
    }

