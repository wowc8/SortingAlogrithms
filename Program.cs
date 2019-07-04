﻿using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSort tester = new TestSort();
            tester.AddASort(new InsertionSort());
            tester.AddASort(new MergeSort());
            tester.TestSorts();
        }
    }
}
