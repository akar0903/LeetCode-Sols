public class Solution {
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        var result = new List<IList<int>>();
        Array.Sort(candidates);
        FormCombinations(0,target,candidates,new List<int>(),result);
        return result;
    }
    static void FormCombinations(int index,int target,int[] candidates,List<int> current,IList<IList<int>> result){
        if(target == 0){
            result.Add(new List<int>(current));
            return;
        }
        for(int i= index;i<candidates.Length;i++){
            if(i>index && candidates[i] == candidates[i-1]) continue;
            if(candidates[i] > target) break;
            current.Add(candidates[i]);
            FormCombinations(i + 1,target - candidates[i],candidates,current,result);
            current.RemoveAt(current.Count-1);
        }
    }
}
