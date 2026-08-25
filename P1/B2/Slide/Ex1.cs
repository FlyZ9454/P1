using System;
using System.Collections.Generic;
using System.Text;

namespace P1.B2.Slide
{
    internal class Ex1
    {
        public static void Run()
        {
            Console.Write("Nhap nhiet do: ");
            float d = float.Parse(Console.ReadLine());
            float k = d + 273;
            float f = d * 1.8f + 32;
            Console.WriteLine($"Nhiet do thang fahrenheit la {f}ᵒF");
            Console.WriteLine($"Nhiet do thang Kelvin la {k}K");
        }
    }
}