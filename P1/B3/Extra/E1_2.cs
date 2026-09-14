using System;
using System.Text;

namespace P1.B3.Extra
{
    internal class E1_2
    {
        public static void Run()
        {
            Console.Write("Nhap vao do tuoi: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Nhap vao khung gio xem: ");
            int time = int.Parse(Console.ReadLine());

            int fee;

            if (age < 12 || age > 60)
            {
                fee = 50000;
            }
            else
            {
                if (time >= 17)
                {
                    fee = 110000;
                }
                else
                {
                    fee = 80000;
                }
            }

            Console.WriteLine($"Gia ve la: {fee:N0} VND");
        }
    }
}