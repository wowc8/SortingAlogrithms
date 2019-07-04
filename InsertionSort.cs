using System;

namespace SortingAlgorithms
{    public static class sort
    {
        public static void InsertionSort(int[] arr)
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

        public static void TestInsertionSort()
        {
            // array to check
            int[] arr1 = new int[]{1,2,3,4,5,6};
            // array when sorted to test against
            int[] arr2 = new int[]{6,5,4,3,2,1};
            Console.WriteLine("Test1 (should return false): " + DoArraysMatch(arr1, arr2));
            InsertionSort(arr1);            
            Console.WriteLine("Test1 (should return true): " + DoArraysMatch(arr1, arr2));
            PrintArray(arr1);
        }

        private static bool DoArraysMatch(int[] arr1, int[] arr2)
        {
            if (arr1.Length != arr2.Length)
                return false;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                    return false;
            }
            return true;
        }
        
        private static void PrintArray(int[] arr)
        {
            Console.Write("Array:{" + arr[0]);
            for (int i = 1; i < arr.Length; i++)
            {
                Console.Write(", " + arr[i]);
            }
            Console.Write("}\n");
        }
    }
}