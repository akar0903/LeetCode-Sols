public class Solution {
    public bool CheckDistances(string s, int[] distance) {
        Dictionary<char,List<int>> letterPosition = new Dictionary<char,List<int>>();
        for(int i=0;i<s.Length;i++){
            if(!letterPosition.ContainsKey(s[i])){
                letterPosition[s[i]] = new List<int>();
            }
            letterPosition[s[i]].Add(i);
        }
        foreach(var entry in letterPosition){
            char letter = entry.Key;
            List<int> position = entry.Value;
            int actualDistance = position[1] - position[0] - 1;
            int expectedDistance = distance[letter - 'a'];
            if (actualDistance != expectedDistance) {
                return false;
            }
        }
        return true;
    }
}
