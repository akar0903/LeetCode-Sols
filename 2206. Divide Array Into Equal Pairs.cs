public class Solution {
    public bool DivideArray(int[] nums) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            if(dict.ContainsKey(nums[i])){
                dict[nums[i]]++;
            }
            else{
                dict[nums[i]] = 1;
            }
        }
        foreach(var kvp in dict){
            if(kvp.Value % 2 != 0 ){
                return false;
            }
        }
        return true;
    }
}
