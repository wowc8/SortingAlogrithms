namespace Algorithms
{    
    public class MinHeap : ABHeap
    {
        public MinHeap(int[] array)
        {
            arr = array;
            CreateHeap(arr);
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
    } 
}