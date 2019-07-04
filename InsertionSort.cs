using System;

namespace SortingAlgorithms
{    public class InsertionSort : ISortingAlgorithm
    {
        public string GetSortName()
        {
            return "Insertion Sort";
        }
        public int[] Sort(int[] arr)
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
            return arr;
        }
    }
}