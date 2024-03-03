/* Maximum Sum Subarray of Size K

Given an array of positive numbers and a positive number ‘k’, find the maximum sum of any contiguous subarray of size ‘k’.

Input: [2, 1, 5, 1, 3, 2], k=3
Output: 9
Explanation: Subarray with maximum sum is [5, 1, 3].
Example 2:

Input: [2, 3, 4, 1, 5], k=2
Output: 7
Explanation: Subarray with maximum sum is [3, 4].
*/

class MaximumSumArrayOfSizeK
{
  public static int findMaxSumSubArray(int k, int[] arr)
  {
    int windowSum = 0, maxSum = 0, windowStart = 0;

    for (int windowEnd = 0; windowEnd < arr.Length; windowEnd++)
    {
      windowSum += arr[windowEnd];

      if (windowEnd >= k - 1)
      {
        maxSum = Math.Max(maxSum, windowSum);
        windowSum -= arr[windowStart];
        windowStart++;
      }
    }

    return maxSum;
  }
};