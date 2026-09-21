using System;
using System.Collections.Generic;
using System.Text;

namespace P1.B5.Extra
{
    internal class E2_5
    {
        public static void Run()
        {
            Console.Write("Nhap so nguyen n: ");
            int n = int.Parse(Console.ReadLine());

            bool ketQua = KiemTraChan(n);
            if (ketQua)
            {
                Console.WriteLine($"{n} la so chan.");
            }
            else
            {
                Console.WriteLine($"{n} la so le.");
            }
        }

        static bool KiemTraChan(int n)
        {
            return n % 2 == 0;
        }
    }
}
