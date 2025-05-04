public class Solution {
    public int FindPeakElement(int[] nums) {
        int low = 0;
        int high = nums.Length - 1;

        while (low < high) {
            int mid = (low + high) / 2;
            
            if (nums[mid] > nums[mid + 1]) {
                high = mid;
            } else{
                low = mid + 1;
            }
        }

        return low; 
    }
}
