using System;
using System.Text;

namespace P1.B3.Extra
{
    internal class E9_2
    {
        public static void Run()
        {
            Console.Write("Nhap thang (1-12): ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Nhap nam: ");
            int year = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine($"Thang {month} nam {year} co 31 ngay.");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine($"Thang {month} nam {year} co 30 ngay.");
                    break;
                case 2:
                    if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                    {
                        Console.WriteLine($"Thang {month} nam {year} co 29 ngay.");
                    }
                    else
                    {
                        Console.WriteLine($"Thang {month} nam {year} co 28 ngay.");
                    }
                    break;
                default:
                    Console.WriteLine("Thang khong hop le.");
                    break;

            }
        }
    }
}