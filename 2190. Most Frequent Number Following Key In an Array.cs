public class Solution {
    public int MostFrequent(int[] nums, int key) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        int result = 0;
        for(int i=0;i<nums.Length - 1;i++){
            if(nums[i] == key){
            if(dict.ContainsKey(nums[i+1])){
                dict[nums[i+1]]++;
            }
            else{
                dict[nums[i+1]] = 1;
            }
            }
        }
        int maxCount =0;
        foreach(var kvp in dict){
            if (kvp.Value > maxCount) {
                maxCount = kvp.Value; 
                result = kvp.Key;     
            }
        }
        return result;
    }
}
