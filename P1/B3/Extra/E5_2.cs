using System;
using System.Text;

namespace P1.B3.Extra
{
    internal class E5_2
    {
        public static void Run()
        {
            Console.Write("Nhap vao so km di chuyen: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal distance) || distance <= 0)
            {
                Console.WriteLine("Quang duong khong hop le!");
                return;
            }
            decimal fare = 0;
            if (distance <= 1)
            {
                fare = 15000m;
            }
            else if (distance <= 10)
            {
                fare = 15000m + (distance - 1) * 12000m;
            }
            else
            {
                fare = 15000m + (9 * 12000m) + (distance - 10) * 10000m;
            }
            if (distance > 30)
            {
                fare *= 0.9m;
            }
            Console.WriteLine($"So tien phai tra la: {fare:N0} VND");
        }
    }
}