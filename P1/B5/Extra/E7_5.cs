using System;
using System.Collections.Generic;
using System.Text;

namespace P1.B5.Extra
{
    internal class E7_5
    {
        public static void Run()
        {
            Console.Write("Nhap so luong phan tu n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write($"Doi voi n = {n}: ");
            InFibonacci(n);
        }

        static void InFibonacci(int n)
        {
            if (n <= 0) return;

            int a = 0, b = 1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                int temp = a + b;
                a = b;
                b = temp;
            }
            Console.WriteLine();
        }
    }
}
