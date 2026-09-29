using P1.B2.Extra;
using System;
using System.Collections.Generic;
using System.Text;

namespace P1.B7
{
    internal class E7_1
    {
        public static void Run()
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập số lượng khách: ");
            int soLuongKhach = int.Parse(Console.ReadLine());

            decimal tongTienChuaGiam = 0m;
            decimal tongTienGiamGia = 0m;
            decimal tongTienSauGiam = 0m;


            for (int k = 1; k <= soLuongKhach; k++)
            {
                Console.WriteLine($"\n--- Nhập thông tin khách thứ {k} ---");

                const decimal basePrice = 100000m;
                decimal discountAmount = 0m;
                decimal weekendFee = 0m;

                Console.Write("Khách hàng (Child, Student, Adult, Senior): ");
                CustomerType customerType = Enum.Parse<CustomerType>(Console.ReadLine(), true);


                decimal tienSauGiamCuaNguoiNay = basePrice - discountAmount + weekendFee;


                tongTienChuaGiam += basePrice + weekendFee;
                tongTienGiamGia += discountAmount;
                tongTienSauGiam += tienSauGiamCuaNguoiNay;
            }
            Console.WriteLine("\n================ HÓA ĐƠN TỔNG ================");
            Console.WriteLine($"Tổng số lượng khách: {soLuongKhach}");
            Console.WriteLine($"Tổng tiền chưa giảm : {tongTienChuaGiam:N0} VNĐ");
            Console.WriteLine($"Tổng tiền giảm giá  : {tongTienGiamGia:N0} VNĐ");
            Console.WriteLine($"TỔNG TIỀN PHẢI TRẢ  : {tongTienSauGiam:N0} VNĐ");
            Console.WriteLine("==============================================");
        }
    }
}
