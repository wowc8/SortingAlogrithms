namespace Algorithms
{
    public class MergeSort : ISortingAlgorithm
    {
        public int numberOfTests { get; set; }
        public bool allowsDecimals { get; set; }
        public bool useRandomGeneratedTesting { get; set; }
        public int FromRandomRange { get; set; }
        public int ToRandomRange { get; set; }

        public MergeSort()
        {       
            numberOfTests = 1000;
            allowsDecimals = false;     
            useRandomGeneratedTesting = true;
            FromRandomRange = -9999;
            ToRandomRange = 999999;
        }
        public string GetSortName()
        {
            return "Merge Sort";
        }
        public int[] Sort(int[] arr)
        {
            return Sort(arr, 0, arr.Length-1);
        }

        private int[] Sort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = (r + l)/2;
                Sort(arr,l,m);
                Sort(arr,m+1,r);
                Merge(arr,l,m,r);
            }
            return arr;
        }
        public double[] Sort(double[] arr)
        {
            return arr;
        }

        public static void Merge(int[] arr, int l, int m, int r)
        {
            int nl = m-l+1;
            int nr = r-m;
            int[] L = new int[nl];
            int[] R = new int[nr];
            for (int i = 0; i < nl; i++)
            {
                L[i] = arr[l+i];
            }
            for (int j = 0; j < nr; j++)
            {
                R[j] = arr[m+j+1];
            }
            int Li = 0;
            int Ri = 0;
            for (int k = l; k <= r; k++)
            {
                if (Ri == nr || (Li < nl && L[Li] >= R[Ri]))
                {
                    arr[k] = L[Li];
                    Li++;
                }
                else
                {
                    arr[k] = R[Ri];
                    Ri++;
                }
            }
        }
    }
}