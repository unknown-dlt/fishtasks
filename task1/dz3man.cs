﻿using System;


namespace def
{
    internal class maxchislo
    {
        static int fac(int[] array)
        {
            int max = 0;
            foreach (int num in array)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine(maximum(array));


        }
    }
}
