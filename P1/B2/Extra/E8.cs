using System;
using System.Collections.Generic;
using System.Text;

namespace P1.B2.Extra
{
    internal class E8
    {
        public static void Run()
        {
            Console.WriteLine("--- Input ---");
            int otp = 839201;
            Console.Write("Ma OTP nhan duoc: ");
            int input = int.Parse(Console.ReadLine());
            DateTime time = DateTime.Now;
            Console.Write("Thoi gian troi qua: ");
            string rtime = Console.ReadLine();
            string[] parts = rtime.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int m = int.Parse(parts[0]);
            int s = int.Parse(parts[2]);
            int t = m * 60 + s;
            Console.WriteLine("--- Output ---");
            string trangthai;
            if (input == otp && t <= 300)
            {
                trangthai = "Xac thuc thanh cong";
            }
            else if (input == otp && t > 300)
            {
                trangthai = "Ma OTP da het han";
            }
            else
            {
                trangthai = "Ban da nhap sai ma OTP";
            }
            Console.WriteLine($"Trang thai xac thuc: {trangthai}");
        }
    }
}