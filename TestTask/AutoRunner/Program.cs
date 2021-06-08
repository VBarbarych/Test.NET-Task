using ClassLibrary;
using System;
using System.Collections.Generic;
using Task1;
using Task2;
using Task3;

namespace AutoRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IRunnable> tasks = new List<IRunnable>();
            tasks.Add(new Sorting());
            tasks.Add(new Search());
            tasks.Add(new Palindrome());
            

            foreach (var task in tasks)
            {
                task.Run();
            }


            Console.ReadKey();
        }
    }
}
