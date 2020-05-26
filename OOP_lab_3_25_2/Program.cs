using System;
using System.IO;

namespace OOP_lab_3_25_2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("input.txt");

            string[] numbers = file.ReadToEnd().Split(new char[] { '\r', '\n', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int[] a = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; ++i)
            {
                a[i] = int.Parse(numbers[i]);
            }

            int max = a[0];

            for (int i = 0; i < numbers.Length; ++i)
            {
                if (max <= a[i])
                {
                    max = a[i];
                }
            }

            Console.WriteLine("Hайбiльший елемент: {0}", max);
        }
    }
}
