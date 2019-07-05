using System;

namespace SortingAlgorithms
{
    public class RadixSort : ISortingAlgorithm
    {
        public string GetSortName()
        {
            return "Radix Sort";
        }

        public int[] Sort(int[] arr)
        {
            // get the largest value
            int maxvalue = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxvalue)
                    maxvalue = arr[i];
            }
            // now figure out how many digits in length this value is;
            string strmaxvalue = maxvalue.ToString();
            int numdigits = strmaxvalue.Length;
            arr = Sort(arr, numdigits);
            return arr;
        }
        public int[] Sort(int[] arr, int numDigits)
        {
            for (int i = 0; i < numDigits; i++)
            {
                arr = CountingSortModified(arr, i+1);
            }
            return arr;
        }
        public int[] CountingSortModified(int[] arr, int digit)
        {
            int maxValue = int.MinValue;
            // get the largest digit within arr wher the digit is in the "digit" place of the number.
            // ex: arr{1234,1245,1256,3295} if digit = 2 then get the largest digit contained in the 2nd 
            // digit place from the front (the 10's spot) from within all numbers.  Which is this case would be 9;
            for (int i = 0; i < arr.Length; i++)
            {
                int value = Util.ExtractDigit(arr[i], digit);
                if (value > maxValue)
                    maxValue = value;
            }
            int[] arrSorted = new int[arr.Length];
            int[] compArray = new int[maxValue+1];
            for (int i = 0; i < maxValue; i++)
            {
                compArray[i] = 0;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                compArray[Util.ExtractDigit(arr[i], digit)]++;
            }
            for (int i = compArray.Length-2; i >= 0; i--)
            {
                compArray[i] += compArray[i+1];
            }
            for (int i = arr.Length-1; i >= 0; i--)
            {
                arrSorted[compArray[Util.ExtractDigit(arr[i], digit)]-1] = arr[i];
                compArray[Util.ExtractDigit(arr[i], digit)]--;
            }
            arr = arrSorted;
            return arr;
        }
    }
}