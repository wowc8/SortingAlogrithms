using System.Collections.Generic;
using System;

namespace Algorithms
{
    public class BucketSort : ISortingAlgorithm
    {        
        public int numberOfTests { get; set; }
        public bool allowsDecimals { get; set; }
        public bool useRandomGeneratedTesting { get; set; }
        public int FromRandomRange { get; set; }
        public int ToRandomRange { get; set; }
        public BucketSort()
        {            
            numberOfTests = 5;
            allowsDecimals = true;
            useRandomGeneratedTesting = true;
            FromRandomRange = 0;
            ToRandomRange = 1;
        }

        public string GetSortName()
        {
            return "Bucket Sort";
        }

        public double[] Sort(double[] arr)
        {
            List<double>[] buckets = new List<double>[arr.Length];
            for (int i = 0; i < buckets.Length; i++)
            {
                buckets[i] = new List<double>();
            }
            for (int i = 0; i < arr.Length; i++)
            {
                buckets[GetHashedIndex(arr,arr[i])].Add(arr[i]);
            }
            InsertionSort iSort = new InsertionSort();
            for (int i = 0; i < buckets.Length; i++)
            {
                iSort.Sort(buckets[i]);
            }
            ConcatinateBucketsIntoArray(buckets, arr);
            return arr;
        }

        private void ConcatinateBucketsIntoArray(List<double>[] buckets, double[] arr)
        {
            int index = 0;
            for (int i = buckets.Length-1; i >= 0; i--)
            {
                for (int j = 0; j < buckets[i].Count; j++)
                {
                    arr[index] = buckets[i][j];
                    index++;
                }
            }
        }

        private int GetHashedIndex(double[] arr, double number)
        {
            int index = (int)(number * arr.Length);
            return index;
        }
        public int[] Sort(int[] arr)
        {
            return arr;
        }
    }
}