using System;

namespace SortingAlgorithms
{    public static class InsertionSort
    {
        public static void Sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i-1;
                while (j >= 0 && arr[j] < key)
                {
                    arr[j+1] = arr[j];
                    j = j - 1;
                }
                arr[j+1] = key;
            }
        }

        public static void TestSort()
        {
            // array to check
            int[] arr1 = new int[]{1,2,3,4,5,6};
            // array when sorted to test against
            int[] arr2 = new int[]{6,5,4,3,2,1};
            Console.WriteLine("Test1 (should return false): " + Util.DoArraysMatch(arr1, arr2));
            Sort(arr1);            
            Console.WriteLine("Test1 (should return true): " + Util.DoArraysMatch(arr1, arr2));
            Util.PrintArray(arr1);
        }
    }
}