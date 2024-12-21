public class Solution {
    public IList<int> TargetIndices(int[] nums, int target) {
        List<int> res = new List<int>();
        int n = nums.Length;
        Array.Sort(nums);
        for (int i = 0; i < n; ++i)
            if (nums[i] == target)
                res.Add(i);
        return res;
    }
}
