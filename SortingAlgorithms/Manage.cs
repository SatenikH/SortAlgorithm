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
            InsertionSort insertionsort = new InsertionSort();
            HeapSort heapsort = new HeapSort();
            BubbleSort bubbleSort = new BubbleSort();
            QuickSort quicksort = new QuickSort();
            MargeSort margesort = new MargeSort();
            int n = arr.Length - 1;

            switch (selection)
            {
                case "1":
                    insertionsort.InsertionSorting(arr);
                    break;
                case "2":
                    bubbleSort.BubbleSorting(arr);
                    break;
                case "3":
                    quicksort.QuickSorting(arr, 0, n);
                    break;
                case "4":
                    heapsort.HeapSorting(arr);
                    break;
                case "5":
                    margesort.mergeSorting(arr, 0, n);
                    break;
                default:
                    Console.WriteLine("???");
                    break;
            }
        }
    }
}
