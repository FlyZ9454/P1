using System;
using System.Text;

namespace P1.B3.Extra
{
    internal class E4_2
    {
        public static void Run()
        {
            Console.Write("Nhap vao so bam: ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 0:
                    Console.WriteLine("[Tong dai]: Quay lai menu chinh");
                    break;
                case 1:
                    Console.WriteLine("[Tong dai]: Gap tong dai vien tu van the");
                    break;
                case 2:
                    Console.WriteLine("[Tong dai]: Tra cuu so du tai khoan");
                    break;
                case 3:
                    Console.WriteLine("[Tong dai]: Bao khoa the khan cap");
                    break;
                case 4:
                    Console.WriteLine("[Tong dai]: Tra cuu ty gia ngoai te");
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le. Vui long chon lai.");
                    break;
            }
        }
    }
}