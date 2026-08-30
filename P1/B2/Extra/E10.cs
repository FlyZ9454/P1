using System;
using System.Collections.Generic;
using System.Text;

namespace P1.B2.Extra
{
    internal class E10
    {
        public static void Run()
        {
            Console.WriteLine("--- Input / Data ---");
            Console.Write("San pham: ");
            string product = Console.ReadLine();
            Console.Write("So luong ton kho: ");
            string stockInput = Console.ReadLine();
            int? stock = int.TryParse(stockInput, out int parsedStock) ? parsedStock : null;
            Console.Write("Restock Date: ");
            string dateInput = Console.ReadLine();
            DateTime? restockDate = DateTime.TryParse(dateInput, out DateTime parsedDate) ? parsedDate : null;
            const int threshold = 10;
            string status;
            if (stock == null || stock == 0)
            {
                status = "OutOfStock";
            }
            else if (stock < threshold)
            {
                status = "LowStock";
            }
            else
            {
                status = "InStock";
            }
            Console.WriteLine("--- Output ---");
            if (stock == null || stock == 0)
            {
                Console.WriteLine("So luong hien thi: 0 (Canh bao: Du lieu trong)");
            }
            else
            {
                Console.WriteLine($"So luong hien thi: {stock}");
            }

            Console.WriteLine($"Trang thai kho: {status}");
            if (restockDate != null)
            {
                Console.WriteLine($"Ngay restock: {restockDate:dd/MM/yyyy}");
            }
            else
            {
                Console.WriteLine("Ngay restock: Chua co lich nhap hang (N/A)");
            }
        }
    }
}