using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace P1.B2.Extra
{
    public enum VehicleType
    {
        Motorbike,
        Car,
        Truck
    }

    internal class E13
    {
        public static void Run()
        {
            Console.WriteLine("--- INPUT ---");
            Console.Write("Loại xe (Motorbike, Car, Truck): ");
            VehicleType type = Enum.Parse<VehicleType>(Console.ReadLine(), true);
            Console.Write("Giờ vào (yyyy-MM-dd HH:mm): ");
            DateTime entryTime = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Giờ ra (yyyy-MM-dd HH:mm): ");
            DateTime exitTime = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
            double rawHours = (exitTime - entryTime).TotalHours;
            int billedHours = (int)Math.Ceiling(rawHours);
            decimal first2HoursFee = 0m;
            decimal nextHourRate = 0m;
            switch (type)
            {
                case VehicleType.Motorbike:
                    first2HoursFee = 5000m;
                    nextHourRate = 2000m;
                    break;
                case VehicleType.Car:
                    first2HoursFee = 20000m;
                    nextHourRate = 10000m;
                    break;
                case VehicleType.Truck:
                    first2HoursFee = 50000m;
                    nextHourRate = 25000m;
                    break;
            }
            decimal baseFee = 0m;
            int extraHours = billedHours > 2 ? billedHours - 2 : 0;

            if (billedHours <= 2)
            {
                baseFee = first2HoursFee;
            }
            else
            {
                baseFee = first2HoursFee + (extraHours * nextHourRate);
            }
            decimal overnightFee = (exitTime.Date > entryTime.Date) ? 30000m : 0m;
            decimal totalFee = baseFee + overnightFee;
            Console.WriteLine("--- OUTPUT ---");
            Console.WriteLine($"Tổng thời gian đỗ: {rawHours:F2} giờ -> Tính phí: {billedHours} giờ");
            if (billedHours <= 2)
            {
                Console.WriteLine($"Phí {billedHours} giờ đầu: {first2HoursFee:N0} VNĐ");
            }
            else
            {
                Console.WriteLine($"Phí 2 giờ đầu: {first2HoursFee:N0} VNĐ");
                Console.WriteLine($"Phí {extraHours} giờ tiếp theo: {extraHours * nextHourRate:N0} VNĐ ({nextHourRate:N0} x {extraHours})");
            }
            if (overnightFee > 0)
            {
                Console.WriteLine($"Phụ phí qua đêm: {overnightFee:N0} VNĐ");
            }
            Console.WriteLine($"TỔNG PHÍ ĐỖ XE: {totalFee:N0} VNĐ");
        }
    }
}