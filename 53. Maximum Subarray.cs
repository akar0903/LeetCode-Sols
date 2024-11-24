public class Solution {
    public int MaxSubArray(int[] nums) {
        int sum = 0;
        int maxsum = nums[0];
        for(int i=0;i<nums.Length;i++){
            sum += nums[i];
            if(nums[i]>sum){
                sum = nums[i];
            }
            if(sum > maxsum){
                maxsum = sum;
            }
        }
        return maxsum;
    }
}
