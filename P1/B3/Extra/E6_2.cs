using System;
using System.Text;

namespace P1.B3.Extra
{
    internal class E6_2
    {
        public static void Run()
        {
            Console.Write("Nhap ma trang thai don hang: ");
            int orderStatus = int.Parse(Console.ReadLine());
            switch (orderStatus)
            {
                case 1:
                    Console.WriteLine("[Trang thai]: Cho xac nhan thanh toan");
                    break;
                case 2:
                    Console.WriteLine("[Trang thai]: Dang dong goi va ban giao don vi van chuyen");
                    break;
                case 3:
                    Console.WriteLine("[Trang thai]: Don hang dang tren duong giao den ban");
                    break;
                case 4:
                    Console.WriteLine("[Trang thai]: Don hang da hoan thanh. Cam on ban!");
                    break;
                case 5:
                    Console.WriteLine("[Trang thai]: Don hang da huy. Xuat phieu hoan tien");
                    break;
                default:
                    Console.WriteLine("Ma trang thai khong hop le. Vui long nhap lai.");
                break;
            }
        }
    }
}