public class Solution {
    public int PivotIndex(int[] nums) {
        int total = 0;
        for(int i=0;i<nums.Length;i++){
            total += nums[i];
        }
        int leftSum = 0;
        for(int i=0;i<nums.Length;i++){
            int rightSum = total - leftSum - nums[i];
            if(rightSum == leftSum){
                return i;
            }
            leftSum += nums[i];
        }
        return -1;
    }
}
