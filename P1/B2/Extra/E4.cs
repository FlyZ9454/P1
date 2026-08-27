using System;
using System.Globalization;

namespace P1.B2.Extra
{
    internal class E4
    {
        public static void Run()
        {
            Console.WriteLine("--- INPUT ---");
            Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");
            string input = Console.ReadLine();
            DateTime birthDate = DateTime.ParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (today < birthDate.AddYears(age))
            {
                age = age - 1;
            }
            TimeSpan songay = today - birthDate;
            int tongngay = (int)songay.TotalDays;
            DateTime nextBirthday = new DateTime(today.Year, birthDate.Month, birthDate.Day);

            if (nextBirthday < today)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }

            TimeSpan sinhnhat = nextBirthday - today;
            int soNgayConLai = (int)sinhnhat.TotalDays;

            Console.WriteLine("--- OUTPUT ---");
            Console.WriteLine($"Tuổi hiện tại: {age} tuổi");
            Console.WriteLine($"Bạn đã sống tổng cộng: {tongngay:N0} ngày");
            Console.WriteLine($"Sinh nhật tiếp theo còn: {soNgayConLai:N0} ngày nữa");
        }
    }
}