public class Solution {
    public int[] ArrayRankTransform(int[] arr) {
        var uniqueElements = arr.Distinct().ToArray();
        Array.Sort(uniqueElements);
        var rankMap = new Dictionary<int, int>();
        for (int i = 0; i < uniqueElements.Length; i++) {
            rankMap[uniqueElements[i]] = i + 1;
        }
        for (int i = 0; i < arr.Length; i++) {
            arr[i] = rankMap[arr[i]];
        }
        return arr;
    }
}
