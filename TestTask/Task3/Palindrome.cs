using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    public class Palindrome : IRunnable
    {
        private List<string> Palindrom(List<string> allTimes)
        {


            var s = allTimes.Where(x => x == new string(x.Reverse().ToArray())).ToList();

            return s;
        }
        

        private List<string> GetAllTimes()
        {
            var listOfTimes = Enumerable.Range(0, 24 * 60).Select(x => TimeSpan.FromMinutes(x).ToString(@"hh\:mm")).ToList();

            return listOfTimes;
        }

        public void Run()
        {
            Console.WriteLine("==========Task3==========\n");

            List<string> allTimes = GetAllTimes();

            List<string> palindromes = Palindrom(allTimes);

            Console.WriteLine("All palindromes: ");

            foreach (var i in palindromes)
            {
                Console.WriteLine(i);
            }
        }
    }
}
