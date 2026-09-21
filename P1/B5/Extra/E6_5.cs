using System;
using System.Collections.Generic;
using System.Text;

namespace P1.B5.Extra
{
    internal class E6_5
    {
        public static void Run()
        {
            Console.Write("Nhap so nguyen n: ");
            int n = int.Parse(Console.ReadLine());

            bool laNguyenTo = KiemTraNguyenTo(n);
            Console.WriteLine($"Output: {laNguyenTo}");
        }

        static bool KiemTraNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}
