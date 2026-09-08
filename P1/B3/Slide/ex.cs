namespace P1.B3.Slide
{
    internal class ex
    {
        public static void Run()
        {
            Console.Write("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
            int y = -5;
            while (y < 5)
            {
                int x = (int)Math.Pow(y, 2) + 2 * y + 1;
                Console.WriteLine(x);
                y += 1;
            }
            Console.WriteLine("Nhap so gio: ");
            decimal c = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Nhap do dai: ");
            decimal d = decimal.Parse(Console.ReadLine());
            decimal s = d / c;
            Console.WriteLine($"Van toc {s:f2}");
            Console.WriteLine("Nhap 1 ki tu: ");


        }
    }
}
