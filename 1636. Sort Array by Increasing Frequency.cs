public class Solution {
    public int[] FrequencySort(int[] nums) {
        var freqmap = new Dictionary<int,int>();
        foreach(int num in nums){
            if(freqmap.ContainsKey(num)){
                freqmap[num]++;
            }
            else{
                freqmap[num] = 1;
            }
        }
        var groupedmap = new Dictionary<int,List<int>>();
        foreach(var kvp in freqmap){
            var num = kvp.Key;
            var freq = kvp.Value;
            if(!groupedmap.ContainsKey(freq)){
                groupedmap[freq] = new List<int>();
            }
            groupedmap[freq].Add(num);
        }
        var sortedNums = new List<int>();
        foreach (var freq in groupedmap.Keys.OrderBy(f => f)) {
            var numsWithSameFreq = groupedmap[freq];
            numsWithSameFreq.Sort((a, b) => b.CompareTo(a)); 
            foreach (var num in numsWithSameFreq) {
                for (int i = 0; i < freq; i++) {
                    sortedNums.Add(num);
                }
            }
        }
        return sortedNums.ToArray();
    }
}
