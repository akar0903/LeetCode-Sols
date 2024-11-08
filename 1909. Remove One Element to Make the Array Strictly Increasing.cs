public class Solution {
    public bool CanBeIncreasing(int[] nums) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        int count=0;
        if(nums.Length <= 2){
            return true;
        }
        foreach(int nos in nums){
        if(dict.ContainsKey(nos)){
            dict[nos]++;
        }
        else{
            dict[nos]=1;
        }
        }
        for(int i=1;i<nums.Length;i++){
            if(nums[i-1] >= nums[i] ){
                count++;
            if(count > 1) return false; 
            if (i > 1 && nums[i - 2] >= nums[i] && i + 1 < nums.Length && nums[i - 1] >= nums[i + 1]) {
                    return false;
                }
                
            }
        }
        foreach(var kvp in dict){
            int number = kvp.Key;
            int counts = kvp.Value;
            if(kvp.Value > 1){
                return false;
            } 
        }
        if(count == 1){
            return true;
        }
        return true;
    }
    }
