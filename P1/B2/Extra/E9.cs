using System;
using System.Collections.Generic;
using System.Text;

namespace P1.B2.Extra
{
    internal class E9
    {
        public static void Run()
        {
            Console.WriteLine("--- Input ---");
            Console.Write("Luong Gross: ");
            decimal gross = decimal.Parse(Console.ReadLine());

            Console.Write("So nguoi phu thuoc: ");
            int dependents = int.Parse(Console.ReadLine());

            Console.WriteLine("--- Output ---");
            decimal insurance = gross * 0.105m;
            Console.WriteLine($"Giam tru bao hiem (10.5%): {insurance:N0} VND");

            // Thu nhập tính thuế (nếu âm thì quy về 0 để hiển thị hoặc tính toán)
            decimal rawTaxable = gross - insurance - 11000000m - (dependents * 4400000m);
            decimal taxableIncome = rawTaxable > 0 ? rawTaxable : 0m;
            Console.WriteLine($"Thu nhap chiu thue: {taxableIncome:N0} VND");

            decimal tax = 0m;
            if (taxableIncome <= 0)
            {
                tax = 0m;
            }
            else if (taxableIncome <= 5000000m)
            {
                tax = taxableIncome * 0.05m;
            }
            else if (taxableIncome <= 10000000m)
            {
                tax = taxableIncome * 0.10m - 250000m;
            }
            else if (taxableIncome <= 18000000m)
            {
                tax = taxableIncome * 0.15m - 750000m;
            }
            else if (taxableIncome <= 32000000m)
            {
                tax = taxableIncome * 0.20m - 1650000m;
            }
            else if (taxableIncome <= 52000000m)
            {
                tax = taxableIncome * 0.25m - 3250000m;
            }
            else if (taxableIncome <= 80000000m)
            {
                tax = taxableIncome * 0.30m - 5850000m;
            }
            else
            {
                tax = taxableIncome * 0.35m - 9850000m;
            }

            Console.WriteLine($"Thue TNCN phai nop: {tax:f0} VND");

            decimal net = gross - insurance - tax;
            Console.WriteLine($"Luong Net thuc nhan: {net:f0} VND");
        }
    }
}