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
            MinHeap heap = new MinHeap(arr);
            Console.WriteLine(heap);
            while (heap.getHeapSize() > 1)
            {
                heap.Extract_TopRoot();
            }
            Console.WriteLine(heap);
            return heap.GetHeapedArray();
        }
    }

}