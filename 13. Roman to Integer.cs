public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> romanMap = new Dictionary<char, int>() {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

        int result = 0;
        for(int i= 0;i<s.Length;i++){
            int value = romanMap[s[i]];
            if(i + 1 < s.Length && romanMap[s[i + 1]] > value){
                result -= value;
            }
            else{
                result += value;
            }
        }
        return result;
    }
}
