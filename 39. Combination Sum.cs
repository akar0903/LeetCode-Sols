public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        var result = new List<IList<int>>();
        var current = new List<int>();
        FindCombinations(0,target,candidates,current,result);
        return result;
    }
    public void FindCombinations(int index,int target,int[] candidates,List<int> current,List<IList<int>> result){
        if(target == 0){
            result.Add(new List<int>(current));
            return;
        }
        for(int i =index;i<candidates.Length;i++){
            if(candidates[i] <= target){
                current.Add(candidates[i]);
                FindCombinations(i,target - candidates[i],candidates,current,result);
                current.RemoveAt(current.Count - 1);
            }
        } 
    }
}
