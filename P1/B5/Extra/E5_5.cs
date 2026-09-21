using System;
using System.Collections.Generic;
using System.Text;

namespace P1.B5.Extra
{
    internal class E5_5
    {
        public static void Run()
        {
            Console.Write("Nhap chuoi ky tu: ");
            string input = Console.ReadLine();

            string daoNguoc = DaoNguocChuoi(input);
            Console.WriteLine($"Chuoi sau khi dao nguoc: {daoNguoc}");
        }

        static string DaoNguocChuoi(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
