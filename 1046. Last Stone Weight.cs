public class Solution {
    public int LastStoneWeight(int[] stones) {
        List<int> stonelist = new List<int>(stones);
        while (stonelist.Count > 1) {
            int max = int.MinValue;
            int secondmax = int.MinValue;
            int maxindex = -1;
            int secondmaxindex = -1;
            for (int i = 0; i < stonelist.Count; i++) {
                if (stonelist[i] > max) {
                    secondmax = max;
                    max = stonelist[i];
                    secondmaxindex = maxindex;
                    maxindex = i;
                } else if (stonelist[i] > secondmax) {
                    secondmax = stonelist[i];
                    secondmaxindex = i;
                }
            }
            stonelist.RemoveAt(maxindex);
            if (secondmaxindex > maxindex) {
                stonelist.RemoveAt(secondmaxindex - 1);
            } else {
                stonelist.RemoveAt(secondmaxindex);
            }
            if (max != secondmax) {
                stonelist.Add(max - secondmax);
            }
        }
        return stonelist.Count == 0 ? 0 : stonelist[0];
    }
}
