public static class sort
{
    public void InsertionSort(int[] arr)
    {
        for (int i = 1; i < arr.Count(); i++)
        {
            int key = arr[i];
            int j = i-1;
            while (j >= 0 && arr[j+1] > arr[j])
            {
                arr[j+1] = arr[j];
                j = j - 1;
            }
            arr[j] = key;
        }
    }

    public void TestInsertionSort()
    {
        // array to check
        int[] arr1 = new int[]{1,2,3,4,5,6};
        // array when sorted to test against
        int[] arr2 = new int[]{6,5,4,3,2,1};
        Console.WriteLine("Test1: " DoArraysMatch(arr1, arr2));
        //Console.in
    }

    private bool DoArraysMatch(int[] arr1, int[] arr2)
    {
        if (arr1.Count() != arr2.Count())
            return false;
        for (int i = 0; i < arr1.Count(); i++)
        {
            if (arr1[i] != arr2[i])
                return false;
        }
        return true;
    }
}