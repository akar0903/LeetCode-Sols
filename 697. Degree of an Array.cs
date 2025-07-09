public class Solution {
    public int FindShortestSubArray(int[] nums) {
        Dictionary<int,int> freq = new Dictionary<int,int>();
        Dictionary<int,int> first = new Dictionary<int,int>();
        Dictionary<int,int> last = new Dictionary<int,int>();
        for(int i=0;i<nums.Length;i++){
            int num = nums[i];
            if(!first.ContainsKey(num)){
                first[num] = i;
            }
            last[num] = i;
            freq[num] = freq.GetValueOrDefault(num,0)+1;
        }
        int degree = freq.Values.Max();
        int minLength = int.MaxValue;
        foreach(var num in freq.Keys){
            if(freq[num] == degree){
                int length = last[num] - first[num] + 1;
                minLength = Math.Min(minLength,length);
            }
        }
        return minLength;
    }
}
