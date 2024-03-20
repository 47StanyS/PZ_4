using System;

namespace SymbolASCII
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int data = 26;
            char[] intArray = new char[data];

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = (char)('a' + i);
            }
            foreach (char i in intArray)
            {
                Console.WriteLine($"Symbol: {i} ASCII simbol: {(int)i}");
            }
        }
    }
}
