public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }
        Dictionary<char, char> sTot = new Dictionary<char, char>();
        Dictionary<char, char> tTos = new Dictionary<char, char>();
        
        for(int i = 0; i < s.Length; i++) {
            char chars = s[i];
            char chart = t[i];
            if(sTot.ContainsKey(chars)) {
                if(sTot[chars] != chart) {
                    return false;
                }
            } else {
                sTot[chars] = chart; 
            }
            if(tTos.ContainsKey(chart)) {
                if(tTos[chart] != chars) {
                    return false;
                }
            } else {
                tTos[chart] = chars; 
            }
        }
        return true;
    }
}
