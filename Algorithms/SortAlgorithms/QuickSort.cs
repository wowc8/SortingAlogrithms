namespace Algorithms
{
    public class QuickSort : ISortingAlgorithm
    {
        public int numberOfTests { get; set; }
        public bool allowsDecimals { get; set; }        
        public bool useRandomGeneratedTesting { get; set; }
        public int FromRandomRange { get; set; }
        public int ToRandomRange { get; set; }
        public QuickSort()
        {           
            numberOfTests = 0;
            allowsDecimals = false; 
            useRandomGeneratedTesting = false;
            FromRandomRange = 0;
            ToRandomRange = 0;
        }
        public string GetSortName()
        {
            return "Quick Sort";
        }
        public int[] Sort(int[] arr)
        {            
            Sort(arr, 0, arr.Length-1);
            return arr;
        }
        public double[] Sort(double[] arr)
        {
            return arr;
        }

        private int Partition(int[] arr, int l, int r)
        {
            int m = arr[r];
            int lessPartition = l-1;
            for (int i = l; i <= r-1; i++)
            {
                if (arr[i] >= m)
                {
                    lessPartition++;
                    Swap(arr, lessPartition, i);
                }
            }
            Swap(arr, lessPartition+1, r);
            return lessPartition+1;
        }

        private void Sort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = Partition(arr, l, r);
                Sort(arr, l, m-1);
                Sort(arr, m+1, r);
            }
        }

        private void Swap(int[] arr, int i1, int i2)
        {
            int temp = arr[i1];
            arr[i1] = arr[i2];
            arr[i2] = temp;
        }
    }
}