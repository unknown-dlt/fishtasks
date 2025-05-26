
using System;


namespace def
{
    internal class factorial
    {
        static void fac(int num)
        {
            int result = 1;
            for (int i = 1; i < num + 1; i++)
            {
                result *= i;
            }

            Console.WriteLine($"Факториал числа {num} = {result}");

        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Введите число для нахождения факториала");
            int number = Convert.ToInt32(Console.ReadLine());
            fac(number);

        }
    }
}
