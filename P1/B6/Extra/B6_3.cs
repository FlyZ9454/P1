using System;

namespace P1.B6.Extra
{
    internal class MatrixExercise
    {
        public static void Run()
        {
            Console.Write("Nhập số dòng N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột M: ");
            int m = int.Parse(Console.ReadLine());

            int[,] matrix = TaoMaTran(n, m, 1, 100);

            Console.WriteLine("\n--- Ma trận vừa tạo ---");
            InMaTran(matrix);

            Console.Write("\nNhập chỉ số i cần in (tính từ 0): ");
            int i = int.Parse(Console.ReadLine());
            InDongThuI(matrix, i);
            InCotThuI(matrix, i);

            int maxVal = TimMaxMaTran(matrix);
            Console.WriteLine($"\nGiá trị lớn nhất trong ma trận: {maxVal}");

            Console.WriteLine($"Giá trị nhỏ nhất trên dòng {i}: {TimMinDongI(matrix, i)}");
            Console.WriteLine($"Giá trị nhỏ nhất trên cột {i}: {TimMinCotI(matrix, i)}");

            int[,] transposed = ChuyenVi(matrix);
            Console.WriteLine("\n--- Ma trận chuyển vị (M x N) ---");
            InMaTran(transposed);

            InDuongCheo(matrix);
        }

        static int[,] TaoMaTran(int rows, int cols, int min, int max)
        {
            Random rnd = new Random();
            int[,] arr = new int[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    arr[r, c] = rnd.Next(min, max + 1);
                }
            }
            return arr;
        }

        static void InMaTran(int[,] arr)
        {
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    Console.Write($"{arr[r, c],5}");
                }
                Console.WriteLine();
            }
        }

        static void InDongThuI(int[,] arr, int rowIdx)
        {
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);

            if (rowIdx < 0 || rowIdx >= rows)
            {
                Console.WriteLine($"Dòng {rowIdx} không tồn tại!");
                return;
            }

            Console.Write($"Dòng {rowIdx}: ");
            for (int c = 0; c < cols; c++)
            {
                Console.Write(arr[rowIdx, c] + " ");
            }
            Console.WriteLine();
        }

        static void InCotThuI(int[,] arr, int colIdx)
        {
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);

            if (colIdx < 0 || colIdx >= cols)
            {
                Console.WriteLine($"Cột {colIdx} không tồn tại!");
                return;
            }

            Console.Write($"Cột {colIdx}: ");
            for (int r = 0; r < rows; r++)
            {
                Console.Write(arr[r, colIdx] + " ");
            }
            Console.WriteLine();
        }

        static int TimMaxMaTran(int[,] arr)
        {
            int max = arr[0, 0];
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (arr[r, c] > max) max = arr[r, c];
                }
            }
            return max;
        }

        static int TimMinDongI(int[,] arr, int rowIdx)
        {
            int cols = arr.GetLength(1);
            if (rowIdx < 0 || rowIdx >= arr.GetLength(0)) return -1;

            int min = arr[rowIdx, 0];
            for (int c = 1; c < cols; c++)
            {
                if (arr[rowIdx, c] < min) min = arr[rowIdx, c];
            }
            return min;
        }

        static int TimMinCotI(int[,] arr, int colIdx)
        {
            int rows = arr.GetLength(0);
            if (colIdx < 0 || colIdx >= arr.GetLength(1)) return -1;

            int min = arr[0, colIdx];
            for (int r = 1; r < rows; r++)
            {
                if (arr[r, colIdx] < min) min = arr[r, colIdx];
            }
            return min;
        }

        static int[,] ChuyenVi(int[,] arr)
        {
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);
            int[,] result = new int[cols, rows];

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    result[c, r] = arr[r, c];
                }
            }
            return result;
        }

        static void InDuongCheo(int[,] arr)
        {
            int rows = arr.GetLength(0);
            int cols = arr.GetLength(1);

            if (rows != cols)
            {
                Console.WriteLine("\nLưu ý: Không thể in đường chéo vì đây không phải ma trận vuông (N != M).");
                return;
            }

            Console.Write("\nĐường chéo chính: ");
            for (int i = 0; i < rows; i++)
            {
                Console.Write(arr[i, i] + " ");
            }

            Console.Write("\nĐường chéo phụ: ");
            for (int i = 0; i < rows; i++)
            {
                Console.Write(arr[i, rows - 1 - i] + " ");
            }
            Console.WriteLine();
        }
    }
}