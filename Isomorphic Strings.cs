public class Solution {
    public bool IsIsomorphic(string s, string t) {
        Dictionary<char, char> s2t = new Dictionary<char, char>();
        Dictionary<char, char> t2s = new Dictionary<char, char>();        
        for (int i = 0; i < s.Length; i++) {
            char charS = s[i];
            char charT = t[i];
            if ((s2t.ContainsKey(charS) && s2t[charS] != charT) ||
                (t2s.ContainsKey(charT) && t2s[charT] != charS)) {
                return false;
            }
            s2t[charS] = charT;
            t2s[charT] = charS;
        }
        return true;
    }
}
