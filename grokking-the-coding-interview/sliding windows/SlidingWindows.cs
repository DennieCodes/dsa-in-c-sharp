class SlidingWindows
{

  public static int Result(int selection)
  {
    switch (selection)
    {
      case (1):
        return MaximumSumArrayOfSizeK.findMaxSumSubArray(3, [2, 1, 5, 1, 3, 2]);

      case (2):
        return SmallestSubarrayWithAGivenSum.MinSizeSubarraySum(7, [2, 1, 5, 2, 3, 2]);

      default:
        return 0;
    }
  }
}