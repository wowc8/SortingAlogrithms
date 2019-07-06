using System;
using System.Text;

namespace Algorithms
{
    public class HeapSort : ISortingAlgorithm
    {
        public int numberOfTests { get; set; }
        public bool allowsDecimals { get; set; }
        public bool useRandomGeneratedTesting { get; set; }
        public int FromRandomRange { get; set; }
        public int ToRandomRange { get; set; }
        public HeapSort()
        {          
            numberOfTests = 0;
            allowsDecimals = false;  
            useRandomGeneratedTesting = false;
            FromRandomRange = 0;
            ToRandomRange = 0;
        }
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
        public double[] Sort(double[] arr)
        {
            return arr;
        }
    }

}