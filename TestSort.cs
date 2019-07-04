using System;
using System.Collections.Generic;
using System.Dynamic;

namespace SortingAlgorithms
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
            bool result = true;
            foreach (ISortingAlgorithm sort in listOfSorts)
            {
                Console.WriteLine(string.Format("****Testing {0}****", sort.GetSortName()));
                if (!Test(sort))
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
        private bool Test(ISortingAlgorithm sort)
        {
            bool result = false;
            if (Test1(sort))
                if(Test2(sort))
                    if(Test3(sort))
                        if(Test4(sort))
                            if(Test5(sort))
                                result = true;
            return result;
        }        

        #region TestCases
        private static bool Test1(ISortingAlgorithm sort)
        {
            string testname = "Test 1";            
            int[] arr1 = new int[]{1,2,3,4,5,6};// array to check            
            int[] arr2 = new int[]{6,5,4,3,2,1};// array when sorted to test against
            return Test(testname, sort, arr1, arr2);
        }
        private static bool Test2(ISortingAlgorithm sort)
        {
            string testname = "Test 2";            
            int[] arr1 = new int[]{1,1,1,1,1,1,1,2};// array to check            
            int[] arr2 = new int[]{2,1,1,1,1,1,1,1};// array when sorted to test against
            return Test(testname, sort, arr1, arr2);
        }
        private static bool Test3(ISortingAlgorithm sort)
        {
            string testname = "Test 3";
            int[] arr1 = new int[]{1,1,1,1,2,2,2,2}; // array to check
            int[] arr2 = new int[]{2,2,2,2,1,1,1,1}; // array when sorted to test against
            return Test(testname, sort, arr1, arr2);
        }
        private static bool Test4(ISortingAlgorithm sort)
        {
            string testname = "Test 4";
            int[] arr1 = new int[]{5,5,5,5,5,5,5,5,5}; // array to check
            int[] arr2 = new int[]{5,5,5,5,5,5,5,5,5}; // array when sorted to test against
            return Test(testname, sort, arr1, arr2);
        }
        private static bool Test5(ISortingAlgorithm sort)
        {
            string testname = "Test 5";
            int[] arr1 = new int[]{9,8,7,6,5,4,3,2,1}; // array to check            
            int[] arr2 = new int[]{9,8,7,6,5,4,3,2,1}; // array when sorted to test against
            return Test(testname, sort, arr1, arr2);
        }
        #endregion

        #region Helpers

        private static bool Test(string testname, ISortingAlgorithm sort, int[] arr1, int[] arr2)
        {
            Console.WriteLine(testname);
            Console.WriteLine("Input:");
            Util.PrintArray(arr1);
            sort.Sort(arr1);            
            Console.WriteLine("Result:");
            Util.PrintArray(arr1);
            bool isSuccess = Util.DoArraysMatch(arr1, arr2);
            if (isSuccess)
                Console.WriteLine(testname + " Passed");
            else
                Console.WriteLine(testname + " Failed");
            return isSuccess;
        }

        #endregion
    }
}