using System;
using System.Collections.Generic;
using System.Text;

namespace P1.B2.Extra
{
    internal class E1
    {
        public static void Run()
        {
            Console.WriteLine("--- Input ---");
            Console.Write("Nhap chi so dien cu (kWh): ");
            decimal a = decimal.Parse(Console.ReadLine());
            Console.Write("Nhap chi so dien moi (kWh): ");
            decimal b = decimal.Parse(Console.ReadLine());
            if (a <= b)
            {
                decimal c = b - a;
                decimal d = 0;
                if (c <= 50)
                {
                    d = c * 1806;
                }
                else if (c <= 100)
                {
                    d = 50 * 1806 + (c - 50) * 1866;
                }
                else if (c <= 200)
                {
                    d = 50 * 1806 + 50 * 1866 + (c - 100) * 2167;
                }
                else if (c <= 300)
                {
                    d = 50 * 1806 + 50 * 1866 + 100 * 2167 + (c - 200) * 2729;
                }
                else
                {
                    d = 50 * 1806 + 50 * 1866 + 100 * 2167 + 100 * 2729 + (c - 300) * 3050;
                }
                Console.WriteLine("---Output---");
                Console.WriteLine($"So dien tieu thu: {c} kWh");
                Console.WriteLine($"Tien dien chua thue: {d:f0} VND");
                Console.WriteLine($"Thue VAT (8%): {d * 8 / 100:f0} VND");
                Console.WriteLine($"Tong thanh toan: {d * 108 / 100:f0} VND");
            }
            else
            {
                Console.WriteLine("Chi so dien moi phai lon hon hoac bang chi so dien cu.");
            }
        }
    }
}
