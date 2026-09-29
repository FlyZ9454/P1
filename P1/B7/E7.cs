using System;
using System.Collections.Generic;
using System.Text;

namespace P1.B7
{
    internal class E7
    {
        static void Run()
        {
            int age;
            while (true)
            {
                Console.Write("Nhập tuổi (số nguyên dương): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out age) && age > 0)
                {
                    break;
                }

                Console.WriteLine("Lỗi: Tuổi phải là một số nguyên hợp lệ lớn hơn 0. Vui lòng nhập lại!\n");
            }
            Console.WriteLine($"Đã ghi nhận tuổi hợp lệ: {age}");
        }
    }
}
