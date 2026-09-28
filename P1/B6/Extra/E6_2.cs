using System;

namespace P1.B6.Extra
{
    internal class E6_2
    {
        public static void Run()
        {
            int[] array = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Nhập số nguyên thứ {i + 1} = ");
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int k = 0; k < array.Length - 1; k++)
            {
                bool xepsai = false;
                for (int h = 0; h < array.Length - 1 - k; h++)
                {
                    if (array[h] > array[h + 1])
                    {
                        int temp = array[h];
                        array[h] = array[h + 1];
                        array[h + 1] = temp;
                        xepsai = true;
                    }
                }
                if (!xepsai) break;
            }
            Console.WriteLine("\nMảng sau khi sắp xếp tăng dần:");
            Console.WriteLine(string.Join(", ", array));
        }
    }
}