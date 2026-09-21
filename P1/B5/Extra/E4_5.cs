using System;
using System.Collections.Generic;
using System.Text;

namespace P1.B5.Extra
{
    internal class E4_5
    {
        public static void Run()
        {
            Console.Write("Nhap so nguyen duong n: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("Vui long nhap so khong am.");
                return;
            }

            long giaiThua = TinhGiaiThua(n);
            Console.WriteLine($"{n}! = {giaiThua}");
        }

        static long TinhGiaiThua(int n)
        {
            long ketQua = 1;
            for (int i = 1; i <= n; i++)
            {
                ketQua *= i;
            }
            return ketQua;
        }
    }
}
