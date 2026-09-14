using System;
using System.Text;

namespace P1.B3.Extra
{
    internal class E3_2
    {
        public static void Run()
        {
            Console.Write("Nhap vao so du: ");
            decimal balance = decimal.Parse(Console.ReadLine());
            Console.Write("Nhap vao so tien rut: ");
            decimal withdrawalAmount = decimal.Parse(Console.ReadLine());
            while (withdrawalAmount % 50000 != 0)
            {
                Console.WriteLine("So tien rut phai la boi so cua 50000. Vui long nhap lai.");
                Console.Write("Nhap vao so tien rut: ");
                withdrawalAmount = decimal.Parse(Console.ReadLine());
            }
            if (withdrawalAmount > balance)
            {
                Console.WriteLine("So du khong du de thuc hien giao dich.");
            }
            else if (withdrawalAmount > 5000000)
            {
                Console.WriteLine("So tien rut khong duoc vuot qua 5.000.000 VND.");
            }
            else
            {
                balance -= withdrawalAmount;
                Console.WriteLine($"Giao dich thanh cong. So du con lai: {balance:N0} VND");
            }
        }
    }
}