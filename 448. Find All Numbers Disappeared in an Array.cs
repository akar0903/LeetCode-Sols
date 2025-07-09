public class Solution {
    public IList<int> FindDisappearedNumbers(int[] nums) {
        List<int> Notpresent = new List<int>();
        HashSet<int> set = new HashSet<int>(nums);
        for(int i=1;i<=nums.Length;i++){
            if(!set.Contains(i) ){
                Notpresent.Add(i);
            }
        }
        return Notpresent;
    }
}
