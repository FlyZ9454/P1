using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace P1.B2.Extra
{
    public enum CustomerType
    {
        Child,
        Student,
        Adult,
        Senior
    }

    internal class E15
    {
        public static void Run()
        {
            const decimal basePrice = 100000m;

            Console.WriteLine("--- INPUT ---");
            Console.Write("Khách hàng (Child, Student, Adult, Senior): ");
            CustomerType customerType = Enum.Parse<CustomerType>(Console.ReadLine(), true);

            Console.Write("Thẻ SV hợp lệ (True/False): ");
            bool hasStudentCard = bool.Parse(Console.ReadLine());

            Console.Write("Ngày xem (Monday, Tuesday, Wednesday...): ");
            DayOfWeek day = Enum.Parse<DayOfWeek>(Console.ReadLine(), true);
            decimal discountAmount = 0m;
            string discountNote = "";
            if (customerType == CustomerType.Child || customerType == CustomerType.Senior)
            {
                discountAmount = basePrice * 0.5m;
                discountNote = "Giảm giá Trẻ em/Cao tuổi (50%)";
            }
            else if (customerType == CustomerType.Student && hasStudentCard)
            {
                if (day >= DayOfWeek.Monday && day <= DayOfWeek.Thursday)
                {
                    discountAmount = basePrice * 0.3m;
                    discountNote = "Giảm giá SV (30%)";
                }
            }
            else if (customerType == CustomerType.Adult && day == DayOfWeek.Wednesday)
            {
                discountAmount = basePrice * 0.2m;
                discountNote = "Khuyến mãi Thứ 4 Vui Vẻ (20%)";
            }
            decimal weekendFee = 0m;
            if (day == DayOfWeek.Friday || day == DayOfWeek.Saturday || day == DayOfWeek.Sunday)
            {
                weekendFee = 20000m;
            }
            decimal totalPayment = basePrice - discountAmount + weekendFee;
            Console.WriteLine("--- OUTPUT ---");
            Console.WriteLine($"Giá vé gốc: {basePrice:N0} VNĐ");

            if (discountAmount > 0)
            {
                Console.WriteLine($"{discountNote}: -{discountAmount:N0} VNĐ");
            }
            Console.WriteLine($"Phụ thu cuối tuần: {weekendFee:N0} VNĐ");
            Console.WriteLine($"TỔNG TIỀN VÉ: {totalPayment:N0} VNĐ");
        }
    }
}