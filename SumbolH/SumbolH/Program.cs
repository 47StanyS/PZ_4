using System;

namespace SumbolH
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("   ______");
            Console.WriteLine("  /Write/");
            Console.WriteLine(" /text!/ ");
            Console.WriteLine(" ------");
            //Console.WriteLine($"Write text: ");

            var writeText = Console.ReadLine();

            Console.WriteLine("  _  ");
            Console.WriteLine(" | |  Choose");
            Console.WriteLine("_| |_  a");
            Console.WriteLine("\\   / letter");
            Console.WriteLine(" \\ /  ");
            Console.WriteLine("  -  ");
            //Console.WriteLine("choose a letter");

            char chooseSym = Console.ReadLine()[0];

            Console.WriteLine("_________________\n");

            int lenght = writeText.Length;
            int count = 0;

            foreach (char ch in writeText.ToLower())
            {
                if (ch == char.ToLower(chooseSym))
                {
                    count++;
                }
            }
            Console.WriteLine($"Text: '{writeText}' include: {writeText.Length} symbols.");
            Console.WriteLine($"Number of characters found '{chooseSym}': {count}");

        }
    }
}