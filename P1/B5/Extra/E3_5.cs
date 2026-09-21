using System;
using System.Collections.Generic;
using System.Text;

namespace P1.B5.Extra
{
    internal class E3_5
    {
        public static void Run()
        {
            Console.Write("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Nhap so c: ");
            int c = int.Parse(Console.ReadLine());

            int max = TimMax(a, b, c);
            Console.WriteLine($"So lon nhat trong 3 so la: {max}");
        }

        static int TimMax(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }
    }
}
