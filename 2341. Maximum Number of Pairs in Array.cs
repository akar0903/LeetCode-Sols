public class Solution {
    public int[] NumberOfPairs(int[] nums) {
        if(nums.Length == 1){
            return [0,1];
        }
        Dictionary<int,int> dict = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            if(dict.ContainsKey(nums[i])){
                dict[nums[i]]++;
            }
            else{
                dict[nums[i]] = 1;
            }
        }
        int count = 0;
        int count1 = 0;
        foreach(var kvp in dict){
            count += kvp.Value / 2;      
            count1 += kvp.Value % 2; 
        }
        return [count ,count1];
    }
}
