using System;
using System.Text;

internal class B8
{
    static void Run()
    {
        Console.Write("Nhập chuỗi văn bản: ");
        string str = Console.ReadLine() ?? "";
        Console.WriteLine($"\nChuỗi vừa nhập: \"{str}\"");

        DemNguyenAmPhuAm(str, out int vowels, out int consonants);
        Console.WriteLine($"\n--- KẾT QUẢ ĐẾM ---");
        Console.WriteLine($"Số nguyên âm (a, e, i, o, u): {vowels}");
        Console.WriteLine($"Số phụ âm                 : {consonants}");

        Console.Write("\nNhập chuỗi con (substring) cần tìm: ");
        string sub = Console.ReadLine() ?? "";

        bool isPresent = KiemTraChuoiCon(str, sub);
        Console.WriteLine($"\n--- KẾT QUẢ TÌM KIẾM ---");
        Console.WriteLine($"Chuỗi con \"{sub}\" có tồn tại không? -> {isPresent}");

        int index = TimViTriChuoiCon(str, sub);
        if (index != -1)
        {
            Console.WriteLine($"Vị trí xuất hiện đầu tiên của chuỗi con: Index {index}");
        }
        else
        {
            Console.WriteLine($"Không tìm thấy chuỗi con \"{sub}\" trong chuỗi ban đầu!");
        }

        Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
        Console.ReadKey();
    }

    static void DemNguyenAmPhuAm(string text, out int vowelCount, out int consonantCount)
    {
        vowelCount = 0;
        consonantCount = 0;

        string lowerText = text.ToLower();

        for (int i = 0; i < lowerText.Length; i++)
        {
            char c = lowerText[i];

            if (char.IsLetter(c))
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    vowelCount++;
                }
                else
                {
                    consonantCount++;
                }
            }
        }
    }

    static bool KiemTraChuoiCon(string mainStr, string subStr)
    {
        if (string.IsNullOrEmpty(subStr)) return false;

        return mainStr.Contains(subStr, StringComparison.OrdinalIgnoreCase);
    }

    static int TimViTriChuoiCon(string mainStr, string subStr)
    {
        if (string.IsNullOrEmpty(subStr)) return -1;

        return mainStr.IndexOf(subStr, StringComparison.OrdinalIgnoreCase);
    }
}