using System;

namespace P1.B4.Extra
{
    internal class E2_4
    {
        public static void Run()
        {
            Console.Write("Nhap so von ban dau: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal principal) || principal <= 0) return;

            Random rand = new Random();
            while (principal > 0)
            {
                Console.WriteLine($"\n--- VON HIEN TAI: {principal:N0} VND ---");
                Console.Write("Nhap so tien cuoc (hoac nhap 0 de dung): ");
                if (!decimal.TryParse(Console.ReadLine(), out decimal bet) || bet < 0 || bet > principal) continue;
                if (bet == 0) break;

                Console.Write("Chon do kho (1: De [9 lan], 2: TB [6 lan], 3: Kho [4 lan]): ");
                int.TryParse(Console.ReadLine(), out int diff);
                int maxTries = 0;
                decimal multiplier = 0m;

                switch (diff)
                {
                    case 1:
                        maxTries = 9;
                        multiplier = 0.5m;
                        break;
                    case 2:
                        maxTries = 6;
                        multiplier = 1m;
                        break;
                    case 3:
                        maxTries = 4;
                        multiplier = 3m;
                        break;
                    default:
                        Console.WriteLine("Do kho khong hop le!");
                        continue;
                }

                int secret = rand.Next(1, 101);
                bool isWon = false;

                for (int i = 1; i <= maxTries; i++)
                {
                    Console.Write($"Lan {i}/{maxTries} - Doan (1-100): ");
                    if (!int.TryParse(Console.ReadLine(), out int guess) || guess < 1 || guess > 100)
                    {
                        Console.WriteLine("So khong hop le!");
                        i--;
                        continue;
                    }

                    if (guess == secret)
                    {
                        isWon = true;
                        break;
                    }
                    Console.WriteLine(guess < secret ? "So bi an LON hon." : "So bi an NHO hon.");
                }

                if (isWon)
                {
                    decimal winAmount = bet * multiplier;
                    principal += winAmount;
                    Console.WriteLine($"CHUC MUNG! Ban doan dung va thang: +{winAmount:N0} VND");
                }
                else
                {
                    principal -= bet;
                    Console.WriteLine($"HET LUOT! So bi an la {secret}. Ban thua: -{bet:N0} VND");
                }
            }

            Console.WriteLine("\nKet thuc tro choi. Hen gap lai!");
        }
    }
}