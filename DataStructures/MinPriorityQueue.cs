namespace Algorithms
{
    public class MinPriorityQueue : ABHeap
    {
        public MinPriorityQueue(int[] array)
        {
            this.arr = array;
            Heapify(arr, 1);
        }
        
        protected override void Heapify(int[] arr, int root)
        {
            int l = Left(root);
            int r = Right(root);
            int smallest = root;            
            if (r <= this.heapsize && arr[r-1] < arr[root-1])
                smallest = r;                
            if (l <= this.heapsize && arr[l-1] < arr[smallest-1])
                smallest = l;
            if (smallest != root)
            {
                Swap(root-1, smallest-1);
                Heapify(arr, smallest);
            }
        }
        
        public int Minimum()
        {
            return GetTopValue();
        }

        public int Extract_Min()
        {
            return Extract_TopRoot();
        }

        public void Decrease_Key(int nodeIndex, int key)
        {
            if (arr[nodeIndex-1] > key)
            {
                arr[nodeIndex-1] = key;
                while(nodeIndex > 1 && arr[Parent(nodeIndex)-1] > key)
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
            Decrease_Key(this.heapsize, key);
        }
    }
}