using System;
using System.Collections.Generic;
using System.Text;

namespace P1.B2.Extra
{
    internal class E12
    {
        public static void Run()
        {
            Console.WriteLine("--- Input ---");
            Console.Write("Van ban goc: ");
            string originalText = Console.ReadLine();
            Console.Write("Khoa dich chuyen (Shift Key k): ");
            int shiftKey = int.Parse(Console.ReadLine());
            string encryptedText = "";
            string decryptedText = "";
            foreach (char c in originalText)
            {
                if (char.IsUpper(c))
                {
                    char encryptedChar = (char)(((c - 'A' + shiftKey) % 26) + 'A');
                    encryptedText += encryptedChar;
                }
                else if (char.IsLower(c))
                {
                    char encryptedChar = (char)(((c - 'a' + shiftKey) % 26) + 'a');
                    encryptedText += encryptedChar;
                }
                else
                {
                    encryptedText += c;
                }
            }
            foreach (char c in encryptedText)
            {
                if (char.IsUpper(c))
                {
                    char decryptedChar = (char)(((c - 'A' - shiftKey + 26) % 26) + 'A');
                    decryptedText += decryptedChar;
                }
                else if (char.IsLower(c))
                {
                    char decryptedChar = (char)(((c - 'a' - shiftKey + 26) % 26) + 'a');
                    decryptedText += decryptedChar;
                }
                else
                {
                    decryptedText += c;
                }
            }
            Console.WriteLine("--- Output ---");
            Console.WriteLine("Van ban Ma hoa: " + encryptedText);
            Console.WriteLine("Van ban Giai ma: " + decryptedText);
        }
    }
}