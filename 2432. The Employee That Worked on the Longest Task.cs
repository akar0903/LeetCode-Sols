public class Solution {
    public int HardestWorker(int n, int[][] logs) {
        int prior = 0;
        int max = 0;
        int result = 0;
        foreach(int[] item in logs){
            int v = item[1] - prior;
            if(v>max || v==max && result > item[0]){
                max = v;
                result = item[0];
            }
            prior = item[1];
        }
        return result;
    }
}
