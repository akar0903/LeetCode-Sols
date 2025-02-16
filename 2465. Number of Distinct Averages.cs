public class Solution {
    public int DistinctAverages(int[] nums) {
        Array.Sort(nums);
        HashSet<int> unique = new();
        for(int i=0;i<nums.Length/2;i++){
            unique.Add(nums[i]+nums[nums.Length-1-i]);
        }
        return unique.Count;
    }
}
