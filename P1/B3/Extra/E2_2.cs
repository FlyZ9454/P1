using System;
using System.Text;

namespace P1.B3.Extra
{
    internal class E2_2
    {
        public static void Run()
        {
            Console.Write("Nhap vai tro Role: ");
            string? input = Console.ReadLine()?.Trim()?.ToLower();
            switch (input)
            {
                case "admin":
                    Console.WriteLine("[Thong bao]: Toan quyen quan tri he thong");
                    break;
                case "manager":
                    Console.WriteLine("[Thong bao]: Quyen quan li nhan su va xem bao cao");
                    break;
                case "employee":
                    Console.WriteLine("[Thong bao]: Quyen tao va chinh sua ho so ca nhan");
                    break;
                case "guest":
                    Console.WriteLine("[Thong bao]: Chi co quyen xem thong tin cong khai");
                    break;
                default:
                    Console.WriteLine("[Thong bao]: Ma vai tro khong hop le");
                break;
            }
        }
    }
}