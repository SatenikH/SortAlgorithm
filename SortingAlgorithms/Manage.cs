using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public enum Operation : long { InsertionSort = 1, BubbleSort, QuickSort, HeapSort, MergeSort }

    internal class Manage
    {
        private static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write("{0} ", arr[i]);
        }
        public void Caller(int[] arr, string selection)
        {
            SortedAlgorithmis sortedAlgorithmis = new SortedAlgorithmis();
            int n = arr.Length - 1;

            switch (selection)
            {
                case "1":
                    sortedAlgorithmis.InsertionSort(arr);
                    break;
                case "2":
                    sortedAlgorithmis.BubbleSort(arr);
                    break;
                case "3":
                    sortedAlgorithmis.QuickSort(arr, 0, n);
                    break;
                case "4":
                    sortedAlgorithmis.HeapSort(arr);
                    break;
                case "5":
                    sortedAlgorithmis.mergeSort(arr, 0, n);
                    break;
                default:
                    Console.WriteLine("???");
                    break;
            }
        }
    }
}
