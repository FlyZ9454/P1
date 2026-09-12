using System;
using System.Collections.Generic;
using System.Text;

namespace P1.B4
{
    internal class ExB4
    {
        public static void Run()
        {
            //In day so hinh tam giac


            for (int o = 1; o <= 4; o++)
            {
                for (int p = 1; p <= o; p++)
                {
                    Console.Write(p);
                }
                Console.WriteLine();
            }


            //Kiem tra tam giac


            Console.Write("Nhap vao chuoi do dai ba canh: ");
            string dodai = Console.ReadLine();
            string[] parts = dodai.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int[] sides = new int[3];
            for (int i = 0; i < 3; i++)
            {
                sides[i] = int.Parse(parts[i]);
            }
            int a = sides[0];
            int b = sides[1];
            int c = sides[2];
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                Console.WriteLine("Ba canh tren khong tao thanh tam giac hop le");
                return;
            }
            if (a == b && b == c)
            {
                Console.WriteLine("Tam giac deu");
            }
            else if (a == b || b == c || c == a)
            {
                Console.WriteLine("Tam giac can");
            }
            else
            {
                Console.WriteLine("Tam giac thuong");
            }

            for (int x = 1; x < 5; x++)
            {
                for (int y = 1; y <= x; y++)
                {
                    Console.Write(y);
                }
                Console.WriteLine();
            }


            //Tinh tong phep chia


            Console.Write("Nhap vao so n: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0.0;
            for (int h = 1; h <= n; h++)
            {
                sum = sum + 1.0 / h;
                if (h == 1)
                {
                    Console.Write("1");
                }
                else
                {
                    Console.Write($" + 1/{h}");
                }
            }
            Console.WriteLine($"\nKet qua la {sum:f4}");


            //Kiem tra so nguyen to


            Console.Write("Nhap vao mot so: ");
            int d = int.Parse(Console.ReadLine());
            bool isPrime = true;
            while (d < 2)
            {
                Console.WriteLine("So vua nhap khong hop le");
                return;
            }
            if (d == 2)
            {
                Console.WriteLine("So 2 la so nguyen to");
            }
            else
            {
                for (int k = 2; k <= Math.Sqrt(d); k++)
                {
                    if (d % k == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine($"So {d} la mot so nguyen to");
                }
                else
                {
                    Console.WriteLine($"So {d} khong phai la so nguyen to");
                }
            }


            //Kiem tra so hoan hao


            Console.Write("Nhap vao 1 so can kiem tra: ");
            int e = int.Parse(Console.ReadLine());
            int sum1 = 0;
            for (int l = 1; l <= e / 2; l++)
            {
                if (e % l == 0)
                {
                    sum1 = sum1 + l;
                }
            }
            if (sum1 == e)
            {
                Console.WriteLine($"So {e} la mot so hoan hao");
            }
            else
            {
                Console.WriteLine($"So {e} khong phai la so hoan hao");
            }
        }
    }
}
