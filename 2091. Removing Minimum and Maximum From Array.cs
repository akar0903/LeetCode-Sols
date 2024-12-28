public class Solution {
    public int MinimumDeletions(int[] nums) {
        if(nums.Length <= 1){
            return 1;
        }
        int minValue = int.MaxValue;
        int maxValue = int.MinValue;
        int minIndex = 0;
        int maxIndex = 0;
        for(int i=0;i<nums.Length;i++){
            if(nums[i] < minValue){
                minValue = nums[i];
                minIndex = i; 
            }
            if(nums[i] > maxValue){
                maxValue = nums[i];
                maxIndex = i;
            }
        }
        int leftMin = minIndex + 1;  
        int rightMin = nums.Length - minIndex;  
        int leftMax = maxIndex + 1;  
        int rightMax = nums.Length - maxIndex;  
        int removeFromLeft = Math.Max(leftMin, leftMax);  
        int removeFromRight = Math.Max(rightMin, rightMax);  
        int removeFromBoth = Math.Min(leftMin + rightMax, leftMax + rightMin);
        return Math.Min(removeFromLeft, Math.Min(removeFromRight, removeFromBoth));
    }
}
