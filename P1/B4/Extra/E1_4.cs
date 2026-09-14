using System;
using System.Text;

namespace P1.B4.Extra
{
    internal class E1_4
    {
        public static void Run()
        {
            Console.Write("Nhap vao so con xuc xac: ");
            if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
            {
                Console.WriteLine("So luong xuc xac khong hop le!");
                return;
            }

            Random rand = new Random();
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                int value = rand.Next(1, 7);
                Console.WriteLine($"Vien {i}: {value} diem");
                sum += value;
            }

            Console.WriteLine($"\nTong so diem cua {n} con xuc xac la: {sum}");
        }
    }
}