using System;

namespace P1.B4.Extra
{
    internal class E4_4
    {
        public static void Run()
        {
            Console.Write("Nhap vao 1 so can kiem tra: ");
            int e = int.Parse(Console.ReadLine());
            int sum1 = 0;
            for (int l = 1; l <= e / 2; l++)
            {
                if (e % l == 0)
                {
                    sum1 = sum1 + l;
                }
            }
            if (sum1 == e)
            {
                Console.WriteLine($"So {e} la mot so hoan hao");
            }
            else
            {
                Console.WriteLine($"So {e} khong phai la so hoan hao");
            }
        }
    }
}