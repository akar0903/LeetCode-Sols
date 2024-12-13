public class Solution {
    public int FillCups(int[] amount) {
        Array.Sort(amount);
        int sum = amount[0] + amount[1] + amount[2];
        return Math.Max(amount[2], (sum + 1) / 2);
    }
}
