using System;

namespace P1.B5.Extra
{
    internal class E1_5
    {
        public static void Run()
        {
            Console.Write("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());

            int x = TinhTong(a, b);
            Console.WriteLine($"Tong hai so a va b = {x}");
        }

        static int TinhTong(int a, int b)
        {
            return a + b;
        }
    }
}