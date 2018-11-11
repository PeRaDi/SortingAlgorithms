using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    class ArrayBuilder
    {
        public static int[] bars;
        Random rnd = new Random();

        public void Generate(int n)
        {
            bars = new int[n+1];
            for (int i = 1; i <= bars.Length -1; i++)
            {
                bars[i] = i;
                Console.WriteLine(bars[i]);
            }
            int[] randomBars = bars.OrderBy(x => rnd.Next()).ToArray();

            for (int i = 1; i <= randomBars.Length - 1; i++)
            {
                Console.WriteLine(randomBars[i]);
            }
        }
    }
}
