using System;
using System.Collections.Generic;
using System.Text;

namespace P1.B2.Extra
{
    internal class E11
    {
        public static void Run()
        {
            Console.WriteLine("--- Input ---");
            Console.Write("So tien gui: ");
            decimal P = decimal.Parse(Console.ReadLine());
            Console.Write("Lai suat (%/nam): ");
            double r = double.Parse(Console.ReadLine());
            Console.Write("Thoi gian gui (thang): ");
            int n = int.Parse(Console.ReadLine());
            decimal interest = P * (decimal)(r / 100) * n / 12;
            decimal total = P * (decimal)Math.Pow(1 + (r / 100) / 12, n);
            Console.WriteLine("--- Output ---");
            Console.WriteLine($"Tong tien lai (Lai don): {interest:N0} VND");
            Console.WriteLine($"Tong lai (Lai kep): {total:N0} VND");
            Console.WriteLine($"Loi nhuan chenh lech: {total - interest - P:N0} VND (Lai kep toi uu hon)");
        }
    }
}