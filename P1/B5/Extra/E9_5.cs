using System;
using System.Collections.Generic;
using System.Text;

namespace P1.B5.Extra
{
    internal class E9_5
    {
        public static void Run()
        {
            Console.Write("Nhap co so x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Nhap so mu y: ");
            int y = int.Parse(Console.ReadLine());

            double ketQua = TinhLuyThua(x, y);
            Console.WriteLine($"{x}^{y} = {ketQua}");
        }

        static double TinhLuyThua(double x, int y)
        {
            if (y == 0) return 1;

            double ketQua = 1;
            long soMu = Math.Abs((long)y);

            for (long i = 0; i < soMu; i++)
            {
                ketQua *= x;
            }

            return y < 0 ? 1.0 / ketQua : ketQua;
        }
    }
}
