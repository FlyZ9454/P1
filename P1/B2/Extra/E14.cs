using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace P1.B2.Extra
{
    internal class E14
    {
        public static void Run()
        {
            Console.WriteLine("--- Input ---");
            int number;
            while (true)
            {
                Console.Write("Nhap chuoi so: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out number))
                {
                    break;
                }
                Console.WriteLine("Du lieu nhap vao khong hop le. Vui long thu lai!\n");
            }
            Console.WriteLine("--- Output ---");
            Console.WriteLine($"Kiem tra Parse: Thanh cong! Gia tri int = {number}");
            if (number >= byte.MinValue && number <= byte.MaxValue)
            {
                Console.WriteLine("Phu hop kieu byte: CO (Vua van trong dai 0-255)");
            }
            else if (number >= short.MinValue && number <= short.MaxValue)
            {
                Console.WriteLine("Phu hop kieu short: CO");
            }
            else
            {
                Console.WriteLine("Phu hop kieu short: KHONG");
            }
            int absValue = Math.Abs(number);
            string numberString = absValue.ToString(CultureInfo.InvariantCulture);
            int sum = 0;
            string expression = "";
            foreach (char digitChar in numberString)
            {
                int digit = digitChar - '0';
                sum += digit;
                expression += digit + " + ";
            }
            Console.WriteLine($"Tong cac chu so: {expression.TrimEnd('+', ' ')} = {sum}");
            try
            {
                checked
                {
                    int square = number * number;
                }
                Console.WriteLine($"Kiem tra Tran so: An toan trong pham vi int32.");
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Kiem tra Tran so: Co tran so trong pham vi int32.");
            }
        }
    }
}