using System;
using System.Collections;

namespace MatchingPairs
{
    class Program
    {
        private static int i;
        static void Main(string[] args)
        {
            int numberOfPairs;
            Console.WriteLine("Enter the number of pairs : ");
            numberOfPairs = Convert.ToInt32(Console.ReadLine());
            string[] pairs = new string[numberOfPairs];
            Console.WriteLine("Enter the pairs : ");
            for (i=0;i< numberOfPairs; i++)
            {
                pairs[i] = Console.ReadLine();
                pairs[i] = pairs[i].ToLower();
            }
            CountDistinctPairs(pairs, numberOfPairs);

        }
        static void CountDistinctPairs(string[] gotPairs, int gotNumberOfPairs)
        {
            var addingPairsList = new ArrayList();

            for (i = 0; i < gotNumberOfPairs; i++)
            {
                if (addingPairsList.Contains(gotPairs[i]) == false)
                {
                    addingPairsList.Add(gotPairs[i]);
                }
            }

            var distinctPairs = addingPairsList.ToArray();

            Console.WriteLine("Count of distinct pairs : " + distinctPairs.Length);
        }
    }
}
