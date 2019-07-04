using System;
using System.Text;

namespace SortingAlgorithms
{
    public class HeapSort : ISortingAlgorithm
    {
        public string GetSortName()
        {
            return "Heap Sort";
        }

        public int[] Sort(int[] arr)
        {
            Heap_Min heap = new Heap_Min(arr);
            Console.WriteLine(heap);
            while (heap.getHeapSize() > 1)
            {
                heap.Extract_Min();
            }
            Console.WriteLine(heap);
            return heap.GetHeapedArray();
        }
    }

    public class Heap_Min
    {
        private int[] arr;
        private int heapsize;
        public Heap_Min(int[] array)
        {
            arr = array;
            CreateHeap_Min(arr);
        }
        public int[] GetHeapedArray()
        {
            return arr;
        }
        public int Extract_Min()
        {
            int min = arr[0];
            Swap(0, heapsize-1);
            heapsize--;
            Heapify_Min(arr, 1);
            return min;
        }
        public int getHeapSize()
        {
            return heapsize;
        }
        private int Left(int i)
        {
            return i*2;
        }
        private int Right(int i)
        {
            return i*2+1;
        }
        private int Parent(int i)
        {
            return i/2;
        }
        private void Swap(int i1, int i2)
        {
            int temp = arr[i1];
            arr[i1] = arr[i2];
            arr[i2] = temp;
        }
        private void Heapify_Min(int[] arr, int root)
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
                Heapify_Min(arr, smallest);
            }
        }
        private void CreateHeap_Min(int[] arr)
        {
            int nodes = arr.Length /2;
            this.heapsize = arr.Length;
            for (int i = nodes; i > 0; i--)
            {
                Heapify_Min(arr, i);
            }
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
        
    }
    public class Heap_Max
    {
        private int[] arr;
        private int heapsize;
        public Heap_Max(int[] array)
        {
            arr = array;
            CreateHeap_Max(arr);
        }
        public int[] GetHeapedArray()
        {
            return arr;
        }
        public int Extract_Max()
        {
            int max = arr[0];
            Swap(0, heapsize-1);
            heapsize--;
            Heapify_Max(arr, 1);
            return max;
        }
        public int getHeapSize()
        {
            return heapsize;
        }
        private int Left(int i)
        {
            return i*2;
        }
        private int Right(int i)
        {
            return i*2+1;
        }
        private int Parent(int i)
        {
            return i/2;
        }
        private void Swap(int i1, int i2)
        {
            int temp = arr[i1];
            arr[i1] = arr[i2];
            arr[i2] = temp;
        }
        private void Heapify_Max(int[] arr, int root)
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
                Heapify_Max(arr, largest);
            }
        }
        private void CreateHeap_Max(int[] arr)
        {
            int nodes = arr.Length /2;
            this.heapsize = arr.Length;
            for (int i = nodes; i > 0; i--)
            {
                Heapify_Max(arr, i);
            }
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
        
    }
}