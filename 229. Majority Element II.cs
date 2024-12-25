public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        if (nums == null || nums.Length == 0) {
            return new List<int>();
        }
        int min = (nums.Length / 3);
        Dictionary<int,int> dict = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            if(dict.ContainsKey(nums[i])){
                dict[nums[i]]++;
            }
            else{
                dict[nums[i]] = 1;
            }
        }
        List<int> minvalues = new List<int>();
        foreach(var kvp in dict){
            if(kvp.Value > min){
                minvalues.Add(kvp.Key);
            }
        }
        return minvalues;
    }
}
