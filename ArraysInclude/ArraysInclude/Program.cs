using System;

namespace ArraysInclude
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int data = 25;
            int[] intArray = new int[data];
            int counter = 0;

            Random randomGenerator = new Random();

            for (int i = 0; i < data; i++)
            {
                int randomValue = randomGenerator.Next(0, 100);
                intArray[i] = randomValue;
            }

            foreach (int value in intArray)
            {
                if (value % 2 == 0 && value != 0)
                {
                    counter++;
                    Console.Write(value + ", ");
                }
            }
            Console.WriteLine($"Arrays include {counter} pair numbers");

        }
    }
}
