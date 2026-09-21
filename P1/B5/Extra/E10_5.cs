using System;
using System.Collections.Generic;
using System.Text;

namespace P1.B5.Extra
{
    internal class E10_5
    {
        public static void Run()
        {
            Console.Write("Nhap so luong phan tu cua mang: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"arr[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            double trungBinh = TinhTrungBinh(arr);
            Console.WriteLine($"Gia tri trung binh = {trungBinh}");
        }

        static double TinhTrungBinh(int[] arr)
        {
            if (arr == null || arr.Length == 0) return 0;

            long tong = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                tong += arr[i];
            }
            return (double)tong / arr.Length;
        }
    }
}
