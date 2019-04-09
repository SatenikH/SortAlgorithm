using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class QuickSort
    {
        public void QuickSorting(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = partition(arr, low, high);
                QuickSorting(arr, low, pi - 1);
                QuickSorting(arr, pi + 1, high);
            }
        }
        private int partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];

            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;

                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;
        }
    }
}
