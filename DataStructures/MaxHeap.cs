namespace Algorithms
{
    public class MaxHeap : ABHeap
    {
        public MaxHeap(int[] array)
        {
            arr = array;
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
    }

}