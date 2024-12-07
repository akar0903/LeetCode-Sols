public class Solution {
    public double TrimMean(int[] arr) {
        Array.Sort(arr);
        int n = arr.Length;
        int percentToRemove = (int)Math.Floor(n * 0.05);
        int[] trimmedArray = arr.Skip(percentToRemove).Take(n - 2 * percentToRemove).ToArray();
        int sum = 0;
        for(int i=0;i<trimmedArray.Length;i++){
            sum += trimmedArray[i];
        }
        return (double)sum / trimmedArray.Length;

        
    }
}
