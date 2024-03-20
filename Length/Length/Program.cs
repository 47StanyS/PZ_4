using System;

namespace Length
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Write text: ");

            var writeText = Console.ReadLine();

            Console.WriteLine($"Text: '{writeText}' include:'{writeText.Length}' symbols.");
        }
    }
}