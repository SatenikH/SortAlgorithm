using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class GreateRandomArray
    {
        public int[] CreateArray(int count) //ARRAY
        {
            int[] arr = new int[count];

            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 1000);
            }
            return arr;
        }
    }
}
