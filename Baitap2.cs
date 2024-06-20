using System;
using System.Collections.Generic;

class Baitap2
{
    static Dictionary<string, string> dictionary = new Dictionary<string, string>();

    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("1. Them tu moi vao tu dien");
            Console.WriteLine("2. Tra cuu nghia cua tu");
            Console.WriteLine("3. Thoat");

            Console.Write("Chon chuc nang: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddWord();
                    break;
                case 2:
                    LookupWord();
                    break;
                case 3:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Lua chon khong hop le. Vui long thu lai.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void AddWord()
    {
        Console.Write("Nhap tu tieng Anh: ");
        string englishWord = Console.ReadLine();

        if (dictionary.ContainsKey(englishWord))
        {
            Console.WriteLine("Tu nay da co trong tu dien.");
            return;
        }

        Console.Write("Nhap nghia tieng Viet: ");
        string vietnameseDefinition = Console.ReadLine();

        dictionary[englishWord] = vietnameseDefinition;
        Console.WriteLine("Da them tu moi vao tu dien.");
    }

    static void LookupWord()
    {
        Console.Write("Nhap tu tieng Anh can tra cuu: ");
        string englishWord = Console.ReadLine();

        if (dictionary.ContainsKey(englishWord))
        {
            Console.WriteLine($"Nghia cua '{englishWord}' la: {dictionary[englishWord]}");
        }
        else
        {
            Console.WriteLine("Tu nay khong co trong tu dien.");
        }
    }
}