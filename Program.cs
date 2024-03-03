namespace DataStructuresAndAlgorithmsInCSharp;

class DataStructuresAndAlgorithmsInCSharp
{
  static void Main(string[] args)
  {
    // int result = MaximumSumArrayOfSizeK.findMaxSumSubArray(3, [2, 1, 5, 1, 3, 2]);
    int result = SmallestSubarrayWithAGivenSum.MinSizeSubarraySum(7, [2, 1, 5, 2, 3, 2]);

    Console.WriteLine(result);
  }
}
