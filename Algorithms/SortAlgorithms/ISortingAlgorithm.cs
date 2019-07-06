namespace Algorithms
{
    public interface ISortingAlgorithm
    {
        bool allowsDecimals { get; set; }
        int numberOfTests { get; set; }
        bool useRandomGeneratedTesting {get; set;}
        int FromRandomRange { get; set; }
        int ToRandomRange { get; set; }
        int[] Sort(int[] arr);
        double[] Sort(double[] arr);
        string GetSortName();
    }
}