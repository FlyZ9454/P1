using System;
using System.Globalization;

namespace P1.B2.Extra
{
    internal class E5
    {
        public static void Run()
        {
            Console.WriteLine("--- INPUT ---");

            Console.Write("Diem C# (thang 10): ");
            double csharp = double.Parse(Console.ReadLine());
            Console.Write("So tin chi C#: ");
            int tcCSharp = int.Parse(Console.ReadLine());

            Console.Write("Diem Toan (thang 10): ");
            double toan = double.Parse(Console.ReadLine());
            Console.Write("So tin chi Toan: ");
            int tcToan = int.Parse(Console.ReadLine());

            Console.Write("Diem Tieng Anh (thang 10): ");
            double tiengAnh = double.Parse(Console.ReadLine());
            Console.Write("So tin chi Tieng Anh: ");
            int tcTiengAnh = int.Parse(Console.ReadLine());

            int tongTinChi = tcCSharp + tcToan + tcTiengAnh;
            double diemTB = (csharp * tcCSharp + toan * tcToan + tiengAnh * tcTiengAnh) / tongTinChi;

            string xepHi;
            double diem4;
            string xepLoai;

            if (diemTB < 4.0)
            {
                xepHi = "F";
                diem4 = 0.0;
                xepLoai = "Kem (Truot)";
            }
            else if (diemTB < 5.5)
            {
                xepHi = "D";
                diem4 = 1.0;
                xepLoai = "Yeu";
            }
            else if (diemTB < 7.0)
            {
                xepHi = "C";
                diem4 = 2.0;
                xepLoai = "Trung binh";
            }
            else if (diemTB < 8.5)
            {
                xepHi = "B";
                diem4 = 3.0;
                xepLoai = "Kha";
            }
            else
            {
                xepHi = "A";
                diem4 = 4.0;
                xepLoai = "Xuat sac / Gioi";
            }

            Console.WriteLine("--- OUTPUT ---");
            Console.WriteLine($"So tin chi hoc ky: {tongTinChi}");
            Console.WriteLine($"Diem trung binh trong so: {diemTB.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Diem chu quy doi: {xepHi}");
            Console.WriteLine($"Thang diem 4: {diem4.ToString("F1", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Xep loai hoc luc: {xepLoai}");
        }
    }
}