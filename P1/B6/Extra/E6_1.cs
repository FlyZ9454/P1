using System;

namespace P1.B6.Extra
{
    internal class E6_1
    {
        public static void Run()
        {
            Console.Write("Nhập số phần tử trong mảng: ");
            int n = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(1, 101);
            }

            Console.WriteLine("Mảng được tạo: " + string.Join(", ", array));

            decimal avg = TinhTrungBinh(array);
            Console.WriteLine($"Giá trị trung bình của mảng là: {avg:F2}");


            Console.Write("\nNhập số cần tìm trong mảng: ");
            int find = int.Parse(Console.ReadLine());


            bool tonTai = CoChuaGiaTri(array, find);
            Console.WriteLine($"Số {find} có trong mảng không? -> {tonTai}");

            int viTri = TimViTri(array, find);
            if (viTri == -1)
            {
                Console.WriteLine($"Không tìm thấy số {find} trong mảng.");
            }
            else
            {
                Console.WriteLine($"Đã tìm thấy số {find} tại chỉ mục (index): {viTri} (vị trí thứ {viTri + 1})");
            }
        }


        static decimal TinhTrungBinh(int[] arr)
        {
            if (arr == null || arr.Length == 0) return 0m;

            long sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return (decimal)sum / arr.Length;
        }

        static bool CoChuaGiaTri(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    return true;
                }
            }
            return false;
        }

        static int TimViTri(int[] arr, int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}