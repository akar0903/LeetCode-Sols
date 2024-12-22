public class Solution {
    public int LengthOfLIS(int[] nums) {
        if(nums.Length == 0) return 0;
        List<int> lis = new List<int>();
        foreach(int num in nums){
            int pos = lis.BinarySearch(num);
            if(pos < 0){
                pos = ~pos;
            }
            if(pos < lis.Count){
                lis[pos] = num;
            }
            else{
                lis.Add(num);
            }
        }
        return lis.Count;
    }
}
