namespace SortingAlgorithms
{
    public class CountingSort : ISortingAlgorithm
    {
        
        public string GetSortName()
        {
            return "Counting Sort";
        }

        public int[] Sort(int[] arr)
        {
            int maxValue = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maxValue)
                    maxValue = arr[i];
            }
            arr = Sort(arr, maxValue);
            return arr;
        }

        public int[] Sort(int[] arr, int maxValue)
        {
            int[] arrSorted = new int[arr.Length];
            int[] compArray = new int[maxValue+1];
            for (int i = 0; i < maxValue; i++)
            {
                compArray[i] = 0;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                compArray[arr[i]]++;
            }
            for (int i = compArray.Length-2; i >= 0; i--)
            {
                compArray[i] += compArray[i+1];
            }
            for (int i = arr.Length-1; i >= 0; i--)
            {
                arrSorted[compArray[arr[i]]-1] = arr[i];
                compArray[arr[i]]--;
            }
            arr = arrSorted;
            return arr;
        }
    }
}