using System;

namespace Elements
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] ints = new int[50];
            var counter = 0;

            foreach (int value in ints)
            {
                counter += 2;
                ints[value] = counter;
                Console.WriteLine($"Elements: {ints[value]}");
            }
        }
    }
}