using System;
using System.Collections.Generic;
using System.Dynamic;

namespace Algorithms
{
    public class TestSort
    {
        private List<ISortingAlgorithm> listOfSorts;
        public TestSort()
        {
            listOfSorts = new List<ISortingAlgorithm>();
        }
        public void AddASort(ISortingAlgorithm sort)
        {
            listOfSorts.Add(sort);
        }
        public bool TestSorts()
        {
            foreach (ISortingAlgorithm sort in listOfSorts)
            {
                Console.WriteLine(string.Format("****Testing {0}****", sort.GetSortName()));
                if (sort.useRandomGeneratedTesting)
                {
                    if (!TestRandom(sort))
                        return false;
                }
                else
                {
                    if (!TestDefault(sort))
                        return false;
                }
            }
            return true;
        }  
              
        #region TestCases
        private bool TestDefault(ISortingAlgorithm sort)
        {
            Random rand = new Random();
            List<TestCase> cases = new List<TestCase>();
            cases.Add(Test1);
            cases.Add(Test2);
            cases.Add(Test3);
            cases.Add(Test4);
            cases.Add(Test5);
            cases.Add(Test6);
            foreach (TestCase test in cases)
            {
                if (!test.Invoke(sort))
                    return false;
            }
            return true;
        }
        private static bool TestRandom(ISortingAlgorithm sort)
        {
            int nFrom = 0;
            int nTo = 100;
            Random rand = new Random();
            int numTests = sort.numberOfTests;
            int n = 0;
            double[] arr;
            int[] arr1;
            string testname = sort.GetSortName() + " Test";
            for (int i = 0; i < numTests; i++)
            {
                n = rand.Next(nFrom, nTo);
                if (sort.allowsDecimals)
                {                        
                    arr = new double[n];
                    for (int j = 0; j < n; j++)
                    {
                        arr[j] = rand.NextDouble() * (double)sort.ToRandomRange;
                    }
                    if (!Test(testname + " " + i.ToString(), sort, arr))
                        return false;
                }
                else
                {   
                    arr1 = new int[n];
                    for (int j = 0; j < n; j++)
                    {
                        arr1[j] = rand.Next(sort.FromRandomRange, sort.ToRandomRange);
                    }
                    if (!Test(testname + " " + i.ToString(), sort, arr1))
                        return false;
                }
            }
            return true;
        }
        private delegate bool TestCase(ISortingAlgorithm sort);
        private static bool Test1(ISortingAlgorithm sort)
        {
            string testname = sort.GetSortName() + " Test 1";            
            int[] arr1 = new int[]{1,2,3,4,5,6};// array to check                      
            return Test(testname, sort, arr1);
        }
        private static bool Test2(ISortingAlgorithm sort)
        {
            string testname = sort.GetSortName() + " Test 2";            
            int[] arr1 = new int[]{1,1,1,1,1,1,1,2};// array to check                      
            return Test(testname, sort, arr1);
        }
        private static bool Test3(ISortingAlgorithm sort)
        {
            string testname = sort.GetSortName() + " Test 3";
            int[] arr1 = new int[]{1,1,1,1,2,2,2,2}; // array to check          
            return Test(testname, sort, arr1);
        }
        private static bool Test4(ISortingAlgorithm sort)
        {
            string testname = sort.GetSortName() + " Test 4";
            int[] arr1 = new int[]{5,5,5,5,5,5,5,5,5}; // array to check          
            return Test(testname, sort, arr1);
        }
        private static bool Test5(ISortingAlgorithm sort)
        {
            string testname = sort.GetSortName() + " Test 5";
            int[] arr1 = new int[]{9,8,7,6,5,4,3,2,1}; // array to check            
            return Test(testname, sort, arr1);
        }        
        private static bool Test6(ISortingAlgorithm sort)
        {
            string testname = sort.GetSortName() + " Test 6";
            int[] arr1 = new int[]{564,854,789,513,156,758,756,958,3215}; // array to check
            return Test(testname, sort, arr1);
        } 
        
        #endregion

        #region Helpers
        private static bool Test(string testname, ISortingAlgorithm sort, double[] arr1)
        {
            double[] _sort()
            {
                return sort.Sort(arr1);
            }
            CallSort<double> delSort = new CallSort<double>(_sort);
            return Test(testname, delSort, arr1);
        }
        private static bool Test(string testname, ISortingAlgorithm sort, int[] arr1)
        {
            int[] _sort()
            {
                return sort.Sort(arr1);
            }
            CallSort<int> delSort = new CallSort<int>(_sort);
            return Test(testname, delSort, arr1);
        }        
        private delegate T[] CallSort<T>();
        private static bool Test<T>(string testname, CallSort<T> delSort, T[] arr1)
        {
            Console.WriteLine(testname);
            Console.WriteLine("Input:");
            Util.PrintArray(arr1);
            arr1 = delSort.Invoke();            
            Console.WriteLine("Result:");
            Util.PrintArray(arr1);
            //bool isSuccess = Util.DoArraysMatch(arr1, arr2);
            bool isSuccess = isSorted(arr1);
            if (isSuccess)
                Console.WriteLine(testname + " Passed");
            else
                Console.WriteLine(testname + " Failed");
            return isSuccess;
        }
        private static bool isSorted<T>(T[] arr, bool isDecending = true)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                T item1 = arr[i-1];
                T item2 = arr[i];
                if ((isDecending && Comparer<T>.Default.Compare(item1,item2) < 0) || (!isDecending && Comparer<T>.Default.Compare(item1,item2) > 0))
                    return false;
            }
            return true;
        }
        #endregion
    }
}