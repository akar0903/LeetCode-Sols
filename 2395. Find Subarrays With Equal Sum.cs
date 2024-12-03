public class Solution {
    public bool FindSubarrays(int[] nums) {
        HashSet<int> sums = new HashSet<int>();
        for(int i=0;i<nums.Length-1;i++){
            int sum = nums[i] + nums[i+1];
            if(sums.Contains(sum)){
                return true;
            }
            sums.Add(sum);
        }
        return false;
    }
}
