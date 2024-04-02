using System;

namespace Lab18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 15, 250, 23, 457, 456, 321, 875, 246, 190, 234, 800, 9837, 12351 };
            Console.Write("1 ci reqem daxil edin:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("1 ci reqem daxil edin:");
            int num2 = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > num1 && array[i] < num2 && SumOfDigits(array[i]) > 7)
                {
                    Console.WriteLine(array[i]);
                }



            }

        }
        static int SumOfDigits(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
    }
}
