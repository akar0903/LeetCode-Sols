using System;
using System.Linq;

public class Solution {
    public int CountHillValley(int[] nums) {
        int n = nums.Length;
        List<int> uniqueNums = new List<int>();
        for (int i = 0; i < n; i++) {
            if (i == 0 || nums[i] != nums[i - 1]) {
                uniqueNums.Add(nums[i]);
            }
        }
        int count = 0;
        for (int i = 1; i < uniqueNums.Count - 1; i++) {
            if (uniqueNums[i - 1] < uniqueNums[i] && uniqueNums[i + 1] < uniqueNums[i]) {
                count++;
            }
            else if (uniqueNums[i - 1] > uniqueNums[i] && uniqueNums[i + 1] > uniqueNums[i]) {
                count++;
            }
        }
        return count;
    }
}
