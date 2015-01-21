using System;

    class PrintADeckOf52Cards
    {
        static void Main()
        {
            int a = 3;
            int b = 4;
            int c = 5;
            int d = 6;
            for (int i = 2; i < 15; i++)
            {
                if (i > 1 && i < 11)
                {
                    Console.WriteLine(" "  + i + ((char)c) + " " + i + ((char)b) + " " + i + ((char)a) + " " + i + ((char)d));
                }
                else
                {
                    for (int j = i; j < i + 1; j++)
                    {
                        switch (i)
                        {
                            case 11: Console.WriteLine(" J" + (char)c + " J" + (char)b + " J" + (char)a + " J" + ((char)d)); break;
                            case 12: Console.WriteLine(" D" + (char)c + " D" + (char)b + " D" + ((char)a) + " D" + ((char)d)); break;
                            case 13: Console.WriteLine(" K" + (char)c + " K" + (char)b + " K" + ((char)a) + " K" + ((char)d)); break;
                            case 14: Console.WriteLine(" A" + (char)c + " A" + (char)b + " A" + ((char)a) + " A" + ((char)d)); break;
                        }
                    }
                }
            }
        }
    }

