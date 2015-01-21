using System;
using System.Collections.Generic;

    class RandomizeTheNumbers1N
    {
        static void Main()
        {
            Console.Write("Enter a integer : ");
            int n = int.Parse(Console.ReadLine());
            int[] nArray;
            List<int> uniquePos = new List<int>();
            nArray = new int[n];

            Random randomGenerator = new Random();

            for (int i = 0; i < nArray.Length; i++)
            {
                int randomIndex = randomGenerator.Next(nArray.GetLowerBound(0), nArray.GetUpperBound(0));

                while (uniquePos.Contains(randomIndex)) //checking if the number is already printed
                {
                    randomIndex = randomGenerator.Next(nArray.GetLowerBound(0), nArray.GetUpperBound(0) +1);
                }

                nArray[i] = randomIndex +1;
                uniquePos.Add(randomIndex);
                Console.Write(nArray[i]);
            }
        }
    }

