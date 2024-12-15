public class Solution {
    public int MostFrequentEven(int[] nums) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            if(nums[i] % 2 == 0){
            if(dict.ContainsKey(nums[i])){
                dict[nums[i]]++;
            }
            else{
                dict[nums[i]]=1;
            }
            }
        }
        int maxFreq = 0;
        int result = -1;
        foreach (var kvp in dict) {
            if (kvp.Value > maxFreq || (kvp.Value == maxFreq && kvp.Key < result)) {
                maxFreq = kvp.Value;
                result = kvp.Key;
            }
        }
        return result;
    }
}
