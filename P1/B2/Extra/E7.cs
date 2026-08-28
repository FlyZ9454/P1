using System;
using System.Collections.Generic;
using System.Text;

namespace P1.B2.Extra
{
    internal class E7
    {
        public static void Run()
        {
            Console.WriteLine("--- Input ---");
            Console.Write("Quang duong (km): ");
            double s = double.Parse(Console.ReadLine());
            Console.Write("Muc tieu hao (L/100km): ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Gia xang (VND/Lit): ");
            decimal p = decimal.Parse(Console.ReadLine());
            Console.Write("So nguoi di: ");
            int n = int.Parse(Console.ReadLine());
            double e = s / 100 * c;
            decimal t = (decimal)e * p;
            decimal d = Math.Ceiling((t / n) / 1000m) * 1000m;
            Console.WriteLine("--- Output ---");
            Console.WriteLine($"Tong nhien lieu tieu thu: {e:f2} Lit");
            Console.WriteLine($"Tong chi phi xang dau: {t:f0} VND");
            Console.WriteLine($"Chi phi moi nguoi {d:f0} VND");
        }
    }
}