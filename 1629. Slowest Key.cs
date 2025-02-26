public class Solution {
    public char SlowestKey(int[] releaseTimes, string keysPressed) {
        int maxDuration = releaseTimes[0];
        char resultKey = keysPressed[0];
        for(int i=1;i<releaseTimes.Length;i++){
            int diff = releaseTimes[i] - releaseTimes[i-1];
            if(diff > maxDuration || (diff == maxDuration && keysPressed[i] > resultKey)){
                maxDuration = diff;
                resultKey = keysPressed[i];
            }
        }
        return resultKey;
    }
}
