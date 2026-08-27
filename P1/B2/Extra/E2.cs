using System;

namespace P1.B2.Extra
{
    internal class E2
    {
        public static void Run()
        {
            Console.WriteLine("--- INPUT ---");
            Console.Write("Chiều cao (m): ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Cân nặng (kg): ");
            double b = double.Parse(Console.ReadLine());
            double bmi = b / Math.Pow(a, 2);
            string phanloai;
            if (bmi < 18.5)
            {
                phanloai = "Thiếu cân";
            }
            else if (bmi < 23.0)
            {
                phanloai = "Lý tưởng";
            }
            else if (bmi < 25.0)
            {
                phanloai = "iền béo phì";
            }
            else
            {
                phanloai = "Béo phì";
            }
            double Min = 18.5 * Math.Pow(a, 2);
            double Max = 22.9 * Math.Pow(a, 2);

            Console.WriteLine("--- OUTPUT ---");
            Console.WriteLine($"Chỉ số BMI của bạn: {bmi:F2}");
            Console.WriteLine($"Phân loại sức khỏe: {phanloai}");
            Console.WriteLine($"Khuyên dùng: Cân nặng lý tưởng của bạn nên từ {Min:F2} kg đến {Max:F2} kg.");
        }
    }
}