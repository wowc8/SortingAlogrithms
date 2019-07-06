using System;
using System.Collections.Generic;

namespace Algorithms
{    public class InsertionSort : ISortingAlgorithm
    {
        public int numberOfTests { get; set; }
        public bool allowsDecimals { get; set; }
        public bool useRandomGeneratedTesting { get; set; }
        public int FromRandomRange { get; set; }
        public int ToRandomRange { get; set; }
        public InsertionSort()
        {         
            numberOfTests = 0;
            allowsDecimals = false;   
            useRandomGeneratedTesting = false;
            FromRandomRange = 0;
            ToRandomRange = 0;
        }
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
        public double[] Sort(double[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                double key = arr[i];
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
        public List<double> Sort(List<double> arr)
        {
            for (int i = 1; i < arr.Count; i++)
            {
                double key = arr[i];
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