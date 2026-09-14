using System;
using System.Text;

namespace P1.B3.Extra
{
    internal class E8_2
    {
        public static void Run()
        {
            Console.Write("Nhap vao so tien: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            Console.Write("Nhap ma ngoai te: ");
            string currencyCode = Console.ReadLine();
            switch (currencyCode.ToUpper())
            {
                case "USD":
                    amount /= 25400m;
                    break;
                case "EUR":
                    amount /= 27200m;
                    break;
                case "JPY":
                    amount /= 165m;
                    break;
                default:
                    Console.WriteLine("Ma ngoai te khong hop le.");
                    return;
            }
            Console.WriteLine($"So tien sau quy doi: {amount:N0} {currencyCode.ToUpper()}");
        }
    }   
}