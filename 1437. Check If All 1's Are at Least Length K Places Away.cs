public class Solution {
    public bool KLengthApart(int[] nums, int k) {
        int lastIndex = -1; 
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] == 1) {
                if (lastIndex != -1) { 
                    if (i - lastIndex - 1 < k) { 
                        return false;
                    }
                }
                lastIndex = i;
            }
        }
        return true; 
    }
}
