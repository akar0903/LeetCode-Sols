public class Solution {
    public int MaximumDifference(int[] nums) {
        int minVal = nums[0];
        int maxDiff = -1; 
                for(int j=1;j<nums.Length;j++){
                    if(nums[j] > minVal){
                        maxDiff = Math.Max(maxDiff, nums[j] - minVal);
                    }
                    else {
                minVal = nums[j];
            }
            }
        return maxDiff;
    }
}
