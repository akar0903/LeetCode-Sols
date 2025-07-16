public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Dictionary<int,int> freqMap = new Dictionary<int,int>();
        List<int> result = new List<int>();
        foreach(int num in nums1){
            if(freqMap.ContainsKey(num)){
                freqMap[num]++;
            }
            else{
                freqMap[num] = 1;
            }
        }
        foreach(int num in nums2){
            if(freqMap.ContainsKey(num) && freqMap[num] > 0){
                result.Add(num);
                freqMap[num]--;
            }
        }
        return result.ToArray();
    }
}
