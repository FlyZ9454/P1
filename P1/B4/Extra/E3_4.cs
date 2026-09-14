using System;

namespace P1.B4.Extra
{
    internal class E3_4
    {
        public static void Run()
        {
            Console.Write("Nhap vao so n: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0.0;
            for (int h = 1; h <= n; h++)
            {
                sum = sum + 1.0 / h;
                if (h == 1)
                {
                    Console.Write("1");
                }
                else
                {
                    Console.Write($" + 1/{h}");
                }
            }
            Console.WriteLine($"\nKet qua la {sum:f4}");
        }
    }
}
