using System;
using System.Text;

namespace P1.B3.Extra
{
    internal class E7_2
    {
        public static void Run()
        {
            Console.Write("Nhap vao loai xe (bike/car): ");
            string vehicleType = Console.ReadLine()?.Trim().ToLower() ?? "";

            Console.Write("Nhap vao thoi gian gui (1: Ban ngay, 2: Ban dem): ");
            int n = int.Parse(Console.ReadLine());

            string timeName = (n == 1) ? "Ban ngay" : "Ban dem";
            string vehicleName = "";
            int fee = 0;

            switch (vehicleType)
            {
                case "bike":
                    vehicleName = "Xe may";
                    fee = (n == 1) ? 5000 : 10000;
                    break;

                case "car":
                    vehicleName = "O to";
                    fee = (n == 1) ? 30000 : 60000;
                    break;

                default:
                    Console.WriteLine("Loai xe khong hop le!");
                    return;
            }

            Console.WriteLine($"Phi gui xe {vehicleName} ({timeName}) la: {fee:N0} VND");
        }
    }
}