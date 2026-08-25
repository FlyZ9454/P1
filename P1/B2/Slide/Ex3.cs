using System;
using System.Collections.Generic;
using System.Text;

namespace P1.B2.Slide
{
    internal class Ex3
    {
        public static void Run()
        {
            Console.Write("Nhap so thu nhat ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai ");
            float b = float.Parse(Console.ReadLine());
            float s = a + b;
            float d = a - b;
            float p = a * b;
            float d1 = a / b;
            float m = a % b;
            Console.WriteLine($"{a} + {b} = {s}");
            Console.WriteLine($"{a} - {b} = {d}");
            Console.WriteLine($"{a} * {b} = {p}");
            Console.WriteLine($"{a} / {b} = {d1}");
            Console.WriteLine($"{a} mod {b} = {m}");

        }

    }
}
