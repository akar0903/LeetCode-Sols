public class Solution {
    public int NumSubarrayProductLessThanK(int[] nums, int k) {
        if(k<=0){
            return 0;
        }
        int count = 0;
        int left = 0;
        int product = 1;
        for(int right = 0;right<nums.Length;right++){
            product *= nums[right];
            while(product >= k && left <= right){
                product /= nums[left];
                left++;
            }
            count += right - left + 1;
        }
        return count;
        
    }
}
