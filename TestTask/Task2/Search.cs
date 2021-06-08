using ClassLibrary;
using System;

namespace Task2
{
    public class Search : IRunnable
    {
        private int FindDuplicate(int[] arr)
        {

            int duplicate = 0;
            Array.Sort(arr);

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    duplicate = arr[i];
                }
            }

            return duplicate;
        }

        private int[] GenerateArray()
        {
            int[] arr = new int[100];

            for (int i = 0; i < 100; i++)
            {
                arr[i] = i + 1;
            }

            arr[33] = 7; // duplicate

            return arr;
        }

        public void Run()
        {
            Console.WriteLine("==========Task2==========\n");

            int[] arrayDup = GenerateArray();

            Console.WriteLine($"Element that is not unique: {FindDuplicate(arrayDup)}");

            Console.WriteLine("\n");
        }
    }
}
