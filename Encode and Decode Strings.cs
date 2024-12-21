public class Solution {

    public string Encode(IList<string> strs) {
        var encoded = new System.Text.StringBuilder();
        foreach(var str in strs){
            encoded.Append(str.Length).Append("#").Append(str);
        }
        return encoded.ToString();
    }

    public List<string> Decode(string s) {
        var decoded = new List<string>();
        int i = 0;
        while(i < s.Length){
            int sharpIndex = s.IndexOf('#', i);
            int length = int.Parse(s.Substring(i, sharpIndex - i));
            i = sharpIndex + 1;
            decoded.Add(s.Substring(i, length));
            i += length;
        }
        return decoded;
   }
}
