public class Solution {
    public int FindMiddleIndex(int[] nums) {
        int right = nums.Sum();
        int left = 0;
        for(int i=0;i<nums.Length;i++){
            right -= nums[i];
            if(right == left) return i;
            left += nums[i];
        }
        return -1;
    }
}
