public class Solution {
    public int LargestAltitude(int[] gain) {
        int current=0;
        int higest=0;
        foreach(int i in gain)
        {
            current += i;
            if(current>higest){
                higest = current;
            }
        }
        return higest;
    }
}
