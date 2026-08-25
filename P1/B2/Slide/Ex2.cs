using System;
using System.Collections.Generic;
using System.Text;

namespace P1.B2.Slide
{
    internal class Ex2
    {
        public static void Run()
        {
            Console.Write("Nhap ban kinh hinh tru tron ");
            float r = float.Parse(Console.ReadLine());
            double s = 4*Math.PI*Math.Pow(r,2);
            double v = 4/3*Math.PI*Math.Pow(r,3);
            Console.WriteLine($"Dien tich la {s:f2}");
            Console.WriteLine($"The tich la {v:f2}");
        }
    }
}
