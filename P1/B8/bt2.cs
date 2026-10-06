using System;
using System.Collections.Generic;
using System.Text;

namespace P1.B8
{
    internal class bt2
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("BÀI 1");
            Bai1();

            Console.WriteLine("\nBÀI 2");
            Bai2();

            Console.WriteLine("\nNhấn phím bất kỳ để kết thúc chương trình...");
            Console.ReadKey();
        }
        static void Bai1()
        {
            int[][] jagged = new int[][]
            {
            new int[] { 1, 3, 5, 7, 9 }, 
            new int[] { 2, 4, 6 },
            new int[] { 11, 22 }              
            };

            Console.WriteLine("Mảng răng cưa khởi tạo mẫu:");
            InJaggedArray(jagged);
        }
        static void Bai2()
        {
            // 1. Nhập số hàng
            Console.Write("Nhập số hàng của mảng răng cưa: ");
            int rows = int.Parse(Console.ReadLine());

            int[][] arr = new int[rows][];
            Random rnd = new Random();

            for (int r = 0; r < rows; r++)
            {
                Console.Write($"Nhập số cột cho hàng {r}: ");
                int cols = int.Parse(Console.ReadLine());

                arr[r] = new int[cols];

                for (int c = 0; c < cols; c++)
                {
                    arr[r][c] = rnd.Next(1, 100);
                }
            }

            Console.WriteLine("\n--- Dữ liệu mảng răng cưa vừa tạo ---");
            InJaggedArray(arr);

            Console.WriteLine("\n--- Task 1: Phần tử lớn nhất ---");
            InMaxCacHangVaToanMang(arr);

            Console.WriteLine("\n--- Task 2: Sắp xếp tăng dần từng hàng ---");
            SapXepTangDanTungHang(arr);
            InJaggedArray(arr);

            Console.WriteLine("\n--- Task 3: Các số nguyên tố trong mảng ---");
            InSoNguyenTo(arr);

            Console.WriteLine("\n--- Task 4: Tìm vị trí của một số ---");
            Console.Write("Nhập số cần tìm: ");
            int canTim = int.Parse(Console.ReadLine());
            TimKiemTatCaViTri(arr, canTim);
        }

        static void InJaggedArray(int[][] arr)
        {
            for (int r = 0; r < arr.Length; r++)
            {
                Console.Write($"Hàng {r} ({arr[r].Length} phần tử): ");
                for (int c = 0; c < arr[r].Length; c++)
                {
                    Console.Write($"{arr[r][c],4} ");
                }
                Console.WriteLine();
            }
        }

        static void InMaxCacHangVaToanMang(int[][] arr)
        {
            int maxGlobal = arr[0][0];

            for (int r = 0; r < arr.Length; r++)
            {
                if (arr[r].Length == 0) continue;

                int maxRow = arr[r][0];
                for (int c = 1; c < arr[r].Length; c++)
                {
                    if (arr[r][c] > maxRow) maxRow = arr[r][c];
                }

                Console.WriteLine($"Số lớn nhất của hàng {r}: {maxRow}");

                if (maxRow > maxGlobal)
                {
                    maxGlobal = maxRow;
                }
            }

            Console.WriteLine($"=> SỐ LỚN NHẤT TOÀN BỘ MẢNG: {maxGlobal}");
        }

        static void SapXepTangDanTungHang(int[][] arr)
        {
            for (int r = 0; r < arr.Length; r++)
            {
                Array.Sort(arr[r]);
            }
            Console.WriteLine("Đã sắp xếp xong!");
        }

        static void InSoNguyenTo(int[][] arr)
        {
            bool coNguyenTo = false;
            Console.Write("Các số nguyên tố tìm thấy: ");

            for (int r = 0; r < arr.Length; r++)
            {
                for (int c = 0; c < arr[r].Length; c++)
                {
                    if (LaSoNguyenTo(arr[r][c]))
                    {
                        Console.Write($"{arr[r][c]} (tại [{r}][{c}]) | ");
                        coNguyenTo = true;
                    }
                }
            }

            if (!coNguyenTo)
            {
                Console.Write("Không có số nguyên tố nào trong mảng.");
            }
            Console.WriteLine();
        }

        static bool LaSoNguyenTo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        static void TimKiemTatCaViTri(int[][] arr, int value)
        {
            bool timThay = false;
            Console.WriteLine($"Vị trí xuất hiện của số {value}:");

            for (int r = 0; r < arr.Length; r++)
            {
                for (int c = 0; c < arr[r].Length; c++)
                {
                    if (arr[r][c] == value)
                    {
                        Console.WriteLine($"-> Tìm thấy tại vị trí: Hàng [{r}], Cột [{c}]");
                        timThay = true;
                    }
                }
            }

            if (!timThay)
            {
                Console.WriteLine($"Không tìm thấy số {value} trong mảng!");
            }
        }
    }
}
