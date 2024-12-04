public class Solution {
    public int MinimumOperations(int[] nums) {
        HashSet<int> hash = new HashSet<int>();
        foreach(int num in nums){
            if(num != 0){
                hash.Add(num);
            }
        }
        return hash.Count;
    }
}
