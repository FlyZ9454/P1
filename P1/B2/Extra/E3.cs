using System;

namespace P1.B2.Extra
{
	internal class E3
	{
		public static void Run()
		{
			Console.WriteLine("--- INPUT ---");
			Console.Write("Nhap so tien (VND): ");
			decimal a = decimal.Parse(Console.ReadLine());
			Console.Write("Chon ngoai te (1-USD, 2-EUR, 3-JPY, 4-GBP): ");
			int b = int.Parse(Console.ReadLine());
			decimal c = 25400;
			decimal d = 27200;
			decimal e = 165;
			decimal f = 32100;
			Console.WriteLine("--- OUTPUT ---");
			Console.WriteLine($"Phi dich vu (0.5%): {a * 0.005m:f0} VND");
			Console.WriteLine($"So tien VND tinh doi: {a * 0.995m:f0} VND");
			if (b == 1)
			{
				Console.WriteLine($"So tien USD nhan duoc: {(a * 0.995m) / c:f2} USD");
			}
			else if (b == 2)
			{
				Console.WriteLine($"So tien EUR nhan duoc: {(a * 0.995m) / d:f2} EUR");
			}
			else if (b == 3)
			{
				Console.WriteLine($"So tien JPY nhan duoc: {(a * 0.995m) / e:f2} JPY");
			}
			else
			{
				Console.WriteLine($"So tien GBP nhan duoc: {(a * 0.995m) / f:f2} GBP");
			}
		}
	}
}