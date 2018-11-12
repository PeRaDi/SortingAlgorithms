using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    class ArrayBuilder
    {

        public static int[] array;
        public static int[] randomArray;

        static Random rnd = new Random();

        public static void Generate(int n)
        {
            array = new int[n+1];
            for (int i = 1; i <= array.Length -1; i++)
            {
                array[i] = i;
                Console.WriteLine(array[i]);
            }
            randomArray = array.OrderBy(x => rnd.Next()).ToArray();

            for (int i = 1; i <= randomArray.Length - 1; i++)
            {
                Console.WriteLine(randomArray[i]);
            }
        }
    }
}
