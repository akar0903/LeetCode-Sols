public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> myhash = new HashSet<int>();
        foreach(var item in nums){
            if(myhash.Contains(item)){
                return true;
            }
            myhash.Add(item);
        }
        return false;
        
    }
}
