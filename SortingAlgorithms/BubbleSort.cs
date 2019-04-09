using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class BubbleSort
    {
        public void BubbleSorting(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                bool isSorted = true;
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        isSorted = false;
                        Swap(arr, j, j + 1);
                    }
                }
                if (isSorted)
                    return;
            }
        }
        private void Swap(int[] arr, int i1, int i2)
        {
            int temp = arr[i2];
            arr[i2] = arr[i1];
            arr[i1] = temp;
        }
    }
}


