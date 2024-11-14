public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        List<IList<int>> subsets = new List<IList<int>>();
        GenerateSubSets(nums,0,new List<int>(),subsets);
        return subsets;
    }
    private void GenerateSubSets(int[] nums,int index,List<int> current,List<IList<int>> subsets){
        if(index == nums.Length){
            subsets.Add(new List<int>(current));
            return;
        }
        current.Add(nums[index]);
        GenerateSubSets(nums,index + 1,current,subsets);
        current.RemoveAt(current.Count - 1);
        GenerateSubSets(nums,index + 1,current,subsets);

    }
}
