public class Solution {
    public int Flipgame(int[] fronts, int[] backs) {
        HashSet<int> badNumbers = new HashSet<int>();
        for(int i=0;i<fronts.Length;i++){
            if(fronts[i] == backs[i]){
                badNumbers.Add(fronts[i]);
            }
        }
        int mingood = int.MaxValue;
        for(int i=0;i<fronts.Length;i++){
            if(!badNumbers.Contains(fronts[i])){
                mingood = Math.Min(mingood,fronts[i]);
            }
            if(!badNumbers.Contains(backs[i])){
                mingood = Math.Min(mingood,backs[i]);
            }
        }
        return mingood == int.MaxValue ? 0 : mingood;
    }
}
