using System;

namespace Algorithms
{
    public class RandomizedSelect
    {
        public string GetName()
        {
            return "Randomized Select";
        }

        public int SelectIthMax(int[] arr, int i)
        {
            return SelectIthMax(arr, 0, arr.Length-1, i);
        }

        private int SelectIthMax(int[] arr, int l, int r, int i)
        {
            if (l==r)
                return arr[l];
            int m = RandomizedPartition(arr, l, r);
            int k = m - l + 1;
            if (i == k)
                return arr[m];
            else if(i < k)
                return SelectIthMax(arr, l, m - 1, i);
            else
                return SelectIthMax(arr, m + 1, r, i - k);
        }

        private int RandomizedPartition(int[] arr, int l, int r)
        {
            Random rand = new Random();
            int i = rand.Next(l, r);
            Swap(arr, i, r);
            return Partition(arr, l, r);
        }

        private int Partition(int[] arr, int l, int r)
        {
            int pivot = arr[r];
            int i = l - 1;
            for (int j = l; j <= r-1; j++)
            {
                if (arr[j] >= pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i+1, r);
            return i+1;
        }

        private void Swap(int[] arr, int l, int r)
        {
            int temp = arr[l];
            arr[l] = arr[r];
            arr[r] = temp;
        }

    }
}