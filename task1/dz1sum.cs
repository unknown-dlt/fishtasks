﻿using System;

namespace def
{
    internal class sum
    {
        static int suma(int[] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine(suma(array));


        }
    }
}
