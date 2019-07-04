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
            if (Test1())
                if(Test2())
                    if (Test3())
                        if(Test4())
                            Test5();
        }

        private static bool Test1()
        {
            string testname = "Test 1";
            // array to check
            int[] arr1 = new int[]{1,2,3,4,5,6};
            // array when sorted to test against
            int[] arr2 = new int[]{6,5,4,3,2,1};
            Console.WriteLine(testname);
            Util.PrintArray(arr1);
            Console.WriteLine("Input:");
            Sort(arr1);            
            Console.WriteLine("Output:");
            Util.PrintArray(arr1);
            bool isSuccess = Util.DoArraysMatch(arr1, arr2);
            if (isSuccess)
                Console.WriteLine(testname + " Passed");
            else
                Console.WriteLine(testname + " Failed");
            return isSuccess;
        }
        private static bool Test2()
        {
            string testname = "Test 2";
            // array to check
            int[] arr1 = new int[]{1,1,1,1,1,1,1,2};
            // array when sorted to test against
            int[] arr2 = new int[]{2,1,1,1,1,1,1,1};
            Console.WriteLine(testname);
            Util.PrintArray(arr1);
            Console.WriteLine("Input:");
            Sort(arr1);            
            Console.WriteLine("Result:");
            Util.PrintArray(arr1);
            bool isSuccess = Util.DoArraysMatch(arr1, arr2);
            if (isSuccess)
                Console.WriteLine(testname + " Passed");
            else
                Console.WriteLine(testname + " Failed");
            return isSuccess;
        }
        private static bool Test3()
        {
            string testname = "Test 3";
            // array to check
            int[] arr1 = new int[]{1,1,1,1,2,2,2,2};
            // array when sorted to test against
            int[] arr2 = new int[]{2,2,2,2,1,1,1,1};
            Console.WriteLine(testname);
            Util.PrintArray(arr1);
            Console.WriteLine("Input:");
            Sort(arr1);            
            Console.WriteLine("Result:");
            Util.PrintArray(arr1);
            bool isSuccess = Util.DoArraysMatch(arr1, arr2);
            if (isSuccess)
                Console.WriteLine(testname + " Passed");
            else
                Console.WriteLine(testname + " Failed");
            return isSuccess;
        }
        private static bool Test4()
        {
            string testname = "Test 4";
            // array to check
            int[] arr1 = new int[]{5,5,5,5,5,5,5,5,5};
            // array when sorted to test against
            int[] arr2 = new int[]{5,5,5,5,5,5,5,5,5};
            Console.WriteLine(testname);
            Util.PrintArray(arr1);
            Console.WriteLine("Input:");
            Sort(arr1);            
            Console.WriteLine("Result:");
            Util.PrintArray(arr1);
            bool isSuccess = Util.DoArraysMatch(arr1, arr2);
            if (isSuccess)
                Console.WriteLine(testname + " Passed");
            else
                Console.WriteLine(testname + " Failed");
            return isSuccess;
        }
        private static bool Test5()
        {
            string testname = "Test 5";
            // array to check
            int[] arr1 = new int[]{9,8,7,6,5,4,3,2,1};
            // array when sorted to test against
            int[] arr2 = new int[]{9,8,7,6,5,4,3,2,1};
            Console.WriteLine(testname);
            Util.PrintArray(arr1);
            Console.WriteLine("Input:");
            Sort(arr1);            
            Console.WriteLine("Result:");
            Util.PrintArray(arr1);
            bool isSuccess = Util.DoArraysMatch(arr1, arr2);
            if (isSuccess)
                Console.WriteLine(testname + " Passed");
            else
                Console.WriteLine(testname + " Failed");
            return isSuccess;
        }
    }
}