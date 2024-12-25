public class Solution {
    public int MinStartValue(int[] nums) {
        int result = 1;  
        int cumulativeSum = 0;
        foreach (int num in nums) {
            cumulativeSum += num;
            if (cumulativeSum < 1) {
                result = Math.Max(result,1 - cumulativeSum);  
            }
        }
        return result;  
    }
}
