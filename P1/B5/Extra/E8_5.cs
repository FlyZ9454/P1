using System;
using System.Collections.Generic;
using System.Text;

namespace P1.B5.Extra
{
    internal class E8_5
    {
        public static void Run()
        {
            Console.Write("Nhap chuoi s: ");
            string s = Console.ReadLine();

            int soNguyenAm = DemNguyenAm(s);
            Console.WriteLine($"So luong nguyen am: {soNguyenAm}");
        }

        static int DemNguyenAm(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;

            int dem = 0;
            string sLower = s.ToLower();
            string nguyenAm = "aeiou";

            foreach (char c in sLower)
            {
                if (nguyenAm.Contains(c))
                {
                    dem++;
                }
            }
            return dem;
        }
    }
}
