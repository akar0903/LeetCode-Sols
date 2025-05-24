public class Solution {
    public int SubarraySum(int[] nums, int k) {
        Dictionary<int,int> PrefixSumCount = new Dictionary<int,int>();
        PrefixSumCount[0] = 1;
        int count = 0;
        int currentSum = 0;
        foreach(int num in nums){
            currentSum += num;
            if(PrefixSumCount.ContainsKey(currentSum - k)){
                count += PrefixSumCount[currentSum - k];
            }
            if(PrefixSumCount.ContainsKey(currentSum)){
                PrefixSumCount[currentSum]++;
            }
            else{
                PrefixSumCount[currentSum] = 1;
            }
        }
        return count;
    }
}
