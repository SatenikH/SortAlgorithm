using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter array size: size=");
            int n = int.Parse(Console.ReadLine());

            GreateRandomArray greateArr = new GreateRandomArray();
            int[] arr = greateArr.CreateArray(n);
            Print(arr);
            Console.WriteLine();

            Console.WriteLine("select which algorithm you want to perform:");
            Operation Op = new Operation();
            Operation[] OpStr = new Operation[6];
            for (Op = Operation.InsertionSort; Op <= Operation.MergeSort; Op++)
            {
                Console.WriteLine("for {0} key {1}", Op, (int)Op);
                OpStr[(int)Op - 1] = Op;
            }
            Console.WriteLine("for All key 6");
            Console.WriteLine();

            Console.Write("please select number(es) which you want:");
            List<string> substrings = new List<string>();
            string InputStr = Console.ReadLine();
            if (InputStr == "6")
                for (int i = 0; i < 6; i++)
                {
                    substrings.Add((i+1).ToString());
                }
                
            else if (InputStr.IndexOf("-") != -1)
            {
                string str = InputStr.Substring(InputStr.Length - 1);
                int strNum = int.Parse(str);
                substrings.Add(InputStr.Substring(0, 1));
                int i = 0;
                while (int.Parse(substrings[i]) < strNum)
                {
                    int nextValue = int.Parse(substrings[i]) + 1;
                    substrings.Add(nextValue.ToString());
                    i++;
                }
            }
            else
            {
                Char delimiter = ',';
                substrings = InputStr.Split(delimiter).ToList();
            }

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            Manage manage = new Manage();
            if (manage != null)
                for (int i = 0; i < substrings.Count; i++)
                {
                    manage.Caller(arr, substrings[i]);
                    Console.WriteLine();
                    for (int j = 0; j < OpStr.Length; j++)
                    {
                        if (j + 1 == int.Parse(substrings[i]))
                        {
                            Op = OpStr[j];
                        }
                    }
                    Console.WriteLine(@"name of the selected algorithm: {0}", Op);
                    Print(arr);

                    TimeSpan ts = stopWatch.Elapsed;
                    Console.WriteLine();

                    string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                                       ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                    Console.WriteLine("running time of chosen: " + elapsedTime);

                    Console.WriteLine(@"used memory while sorting an array: {0}", GC.GetTotalMemory(false));
                }
            stopWatch.Stop();

            Console.ReadLine();
        }
        private static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write("{0} ", arr[i]);
        }
    }
}
