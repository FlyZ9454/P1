using System;
using System.Text;

namespace P1.B3.Extra
{
    internal class E10_2
    {
        public static void Run()
        {
            Console.Write("Nhap mat khau: ");
            string password = Console.ReadLine();
            switch (password.Length)
            {
                case < 6:
                    Console.WriteLine("Mat khau Yeu: Qua ngan (toi thieu 6 ky tu)");
                    break;
                case >= 6 and <= 10:
                    Console.WriteLine("Mat khau Trung binh: Nen ket hop ki tu dac biet");
                    break;
                default:
                    Console.WriteLine("Mat khau manh");
                    break;
            }
        }
    }
}