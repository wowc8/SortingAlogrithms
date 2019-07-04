using System;

namespace SortingAlgorithms
{
    public class Util    {
         public static bool DoArraysMatch(int[] arr1, int[] arr2)
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

        public static void PrintArray(int[] arr)
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