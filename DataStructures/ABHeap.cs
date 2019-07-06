namespace Algorithms
{
    public abstract class ABHeap
    {        
        protected int[] arr;
        protected int heapsize;
        public int[] GetHeapedArray()
        {
            return arr;
        }
        public int Extract_TopRoot()
        {
            int max = arr[0];
            Swap(0, heapsize-1);
            heapsize--;
            Heapify(arr, 1);
            return max;
        }
        public int getHeapSize()
        {
            return heapsize;
        }
        protected int Left(int i)
        {
            return i*2;
        }
        protected int Right(int i)
        {
            return i*2+1;
        }
        protected int Parent(int i)
        {
            return i/2;
        }
        protected void Swap(int i1, int i2)
        {
            int temp = arr[i1];
            arr[i1] = arr[i2];
            arr[i2] = temp;
        }
        
        protected void CreateHeap(int[] arr)
        {
            int nodes = arr.Length /2;
            this.heapsize = arr.Length;
            for (int i = nodes; i > 0; i--)
            {
                Heapify(arr, i);
            }
        }

        public int GetTopValue()
        {
            return arr[0];
        }

        public override string ToString()
        {
            Util.PrintArray(this.arr);
            // StringBuilder sb = new StringBuilder();
            // for (int i = 0; i<this.arr.Length; i++)
            // {
            //     sb.Append(" ");
            // }
            // string row = sb.ToString();

            return "";
        }

        protected abstract void Heapify(int[] arr, int root);
    }    
}