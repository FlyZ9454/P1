using System;
using System.Globalization;

namespace P1.B2.Extra
{
    internal class E6
    {
        public static void Run()
        {
            Console.WriteLine("--- INPUT ---");
            Console.Write("Nhap ho ten tho: ");
            string hoTentho = Console.ReadLine();
            string hoTen = string.Join(" ", hoTentho.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            string ho = hoTen.Substring(0, hoTen.IndexOf(' '));
            string ten = hoTen.Substring(hoTen.LastIndexOf(' ') + 1);
            string tenDem = hoTen.Substring(hoTen.IndexOf(' ') + 1, hoTen.LastIndexOf(' ') - hoTen.IndexOf(' ') - 1);
            string Ho = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ho.ToLower());
            string TenDem = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tenDem.ToLower());
            string Ten = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ten.ToLower());
            string username = $"{Ten.ToLower()}.{Ho.ToLower()}{TenDem.ToLower()}";
            string email = $"{username}@company.edu.vn";
            Console.WriteLine("--- OUTPUT ---");
            Console.WriteLine($"Ho ten chuan hoa: {Ho} {TenDem} {Ten}");
            Console.WriteLine($"Ho: {Ho} | Ten dem: {TenDem} | Ten: {Ten}");
            Console.WriteLine($"Username tao phat tu dong: {username}");
            Console.WriteLine($"Email cap phat: {email}");
        }
    }
}