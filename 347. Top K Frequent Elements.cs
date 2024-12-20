public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            if(dict.ContainsKey(nums[i])){
                dict[nums[i]]++;
            }
            else{
                dict[nums[i]] = 1;
            }
        }
        var buckets = new List<int>[nums.Length + 1];
        foreach(var pair in dict){
            int frequency = pair.Value;
            if(buckets[frequency] == null){
                buckets[frequency] = new List<int>();
            }
            buckets[frequency].Add(pair.Key);
        }
        var result = new List<int>();
        for(int i = buckets.Length - 1 ;i >= 0 && result.Count < k;i--){
            if(buckets[i] != null){
                result.AddRange(buckets[i]);
            }
        }
        return result.Take(k).ToArray();
    }
}
