public class Solution {
    public int FindPoisonedDuration(int[] timeSeries, int duration) {
        if (timeSeries.Length == 0 || duration == 0)
            return 0;
        int totalPoisonTime = 0;
        for (int i = 0; i < timeSeries.Length - 1; i++) {
            int gap = timeSeries[i + 1] - timeSeries[i];
            totalPoisonTime += Math.Min(duration, gap);
        }
        totalPoisonTime += duration;
        return totalPoisonTime;
    }
}
