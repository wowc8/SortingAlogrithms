using System;

namespace Algorithms
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
        public static void PrintArray<T>(T[] arr)
        {
            if (arr.Length < 1)
            {
                Console.Write("Array:{}\n");
                return;
            }
            Console.Write("Array:{" + arr[0]);
            for (int i = 1; i < arr.Length; i++)
            {
                Console.Write(", " + arr[i]);
            }
            Console.Write("}\n");
        }
        public static int ExtractDigit(int num, int digit)
        {
            int result = (int)Math.Floor(num/(Math.Pow(10, digit-1))) % 10;
            return result;
        }
    }
}