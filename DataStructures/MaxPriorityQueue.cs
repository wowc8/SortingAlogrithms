namespace Algorithms
{
    public class MaxPriorityQueue : ABHeap
    {
        public MaxPriorityQueue(int[] array)
        {
            this.arr = array;
            CreateHeap(arr);
        }
        protected override void Heapify(int[] arr, int root)
        {
            int l = Left(root);
            int r = Right(root);
            int largest = root;            
            if (r <= this.heapsize && arr[r-1] > arr[root-1])
                largest = r;
            if (l <= this.heapsize && arr[l-1] > arr[largest-1])
                largest = l;
            if (largest != root)
            {
                Swap(root-1, largest-1);
                Heapify(arr, largest);
            }
        }

        public int Maximum()
        {
            return GetTopValue();
        }

        public int Extract_Max()
        {
            return Extract_TopRoot();
        }

        public void Increase_Key(int nodeIndex, int key)
        {
            if (arr[nodeIndex-1] < key)
            {
                arr[nodeIndex-1] = key;
                while(nodeIndex > 1 && arr[Parent(nodeIndex)-1] < key)
                {
                    Swap(nodeIndex-1, Parent(nodeIndex)-1);
                    nodeIndex = Parent(nodeIndex);
                }
            }
        }

        public void Insert(int key)
        {
            this.heapsize++;
            arr[this.heapsize-1] = int.MinValue;
            Increase_Key(this.heapsize, key);
        }
    }
}