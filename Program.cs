using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSelect();
        }

        public static void TestSelect()
        {
            Random rand = new Random();
            int numTests = 5;
            int nfrom = -99999;
            int nto = 99999;
            RandomizedSelect select = new RandomizedSelect();
            QuickSort sort = new QuickSort();
            Console.WriteLine(String.Format("****Testing {0}****", select.GetName()));
            for (int i = 0; i < numTests; i++)
            {
                int arraysize = rand.Next(0,15);
                int[] arr = new int[arraysize];
                Console.WriteLine(String.Format("****{0} Test{1}", select.GetName(), i+1));
                for (int j = 0; j < arraysize; j++)
                {
                    arr[j] = rand.Next(nfrom, nto);
                }
                Console.WriteLine(String.Format("****{0} Array = ", select.GetName()));
                Util.PrintArray(arr);
                // select ith largest
                int ith = rand.Next(1, arr.Length);
                int ithLargestValue = select.SelectIthMax(arr, ith);
                arr = sort.Sort(arr);
                
                Console.WriteLine(String.Format("****{0} Array Sorted", select.GetName()));
                Util.PrintArray(arr);
                Console.WriteLine(String.Format("****{0} i = {1}, ith = {2}, {2} =? {3}", select.GetName(), ith, arr[ith-1], ithLargestValue));
                if (arr[ith-1] != ithLargestValue)
                {
                    Console.WriteLine(String.Format("****{0} Test{1} Faild", select.GetName(), i+1));                    
                    return;
                }
                Console.WriteLine(String.Format("****{0} Test{1} Passed!", select.GetName(), i+1));
            }
        }
        public static void TestSorts()
        {
            TestSort sorttester = new TestSort();
            sorttester.AddASort(new InsertionSort());
            sorttester.AddASort(new MergeSort());
            sorttester.AddASort(new HeapSort());
            sorttester.AddASort(new QuickSort());
            sorttester.AddASort(new CountingSort());
            sorttester.AddASort(new RadixSort());
            sorttester.AddASort(new BucketSort());
            sorttester.TestSorts();
        }
    }
}
