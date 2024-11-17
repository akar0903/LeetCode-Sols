public class Solution {
    public void Solve(int[] nums,int l,int r,IList<IList<int>> result){
        if( l == r){
            result.Add(new List<int>(nums));
            return;
        }
        for(int i=l;i<=r;i++){
            Swap(nums,l,i);
            Solve(nums,l+1,r,result);
            Swap(nums,l,i);
        }
    }
    public void Swap(int[] nums,int i,int j){
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
   
    public IList<IList<int>> Permute(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();
        Solve(nums,0,nums.Length-1,result);
        return result;
    }
}
