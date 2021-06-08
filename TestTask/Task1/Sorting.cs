using System;
using ClassLibrary;

namespace Task1
{
    public class Sorting : IRunnable
    {
        private int[] SortArray(int[] A, int[] B)
        {
            int[] result = new int[A.Length + B.Length];
            int counter, i, j;

            for (i = j = counter = 0; i < A.Length && j < B.Length; counter++)
            {
                result[counter] = A[i] < B[j] ? A[i++] : B[j++];
            }

            while (i < A.Length)
                result[counter++] = A[i++];

            while (j < B.Length)
                result[counter++] = B[j++];

            return result;
        }

        public void Run()
        {
            Console.WriteLine("==========Task1==========\n");
            Console.Write("Merge two sorted arrays: ");
            int[] SortedArray = SortArray(new int[] { 2, 4, 8, 34 }, new int[] { 2, 5, 6, 8, 12, 42, 54 });
            foreach(var i in SortedArray)
                Console.Write(i + " ");

            Console.WriteLine("\n");
        }
    }
}
