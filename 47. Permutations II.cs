public class Solution {
    public void Solve(int[] nums,int l,int r,IList<IList<int>> result,HashSet<string> seen){
        if(l==r){
            string permuntationkey = string.Join(",",nums);
            if(!seen.Contains(permuntationkey)){
                result.Add(new List<int>(nums));
                seen.Add(permuntationkey);
            }
            return;
        }
        for(int i=l;i<=r;i++){
            if(i != l && nums[i] == nums[l]){
                continue;
            }
            Swap(nums,l,i);
            Solve(nums,l+1,r,result,seen);
            Swap(nums,l,i);
        }
    }
    public void Swap(int[] nums,int i,int j){
        int temp = nums[i];
        nums[i]=nums[j];
        nums[j]=temp;
    }
    public IList<IList<int>> PermuteUnique(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>(); 
        Array.Sort(nums);
        HashSet<string> seen = new HashSet<string>();
        Solve(nums, 0, nums.Length - 1, result, seen);
        return result;
    }
}
