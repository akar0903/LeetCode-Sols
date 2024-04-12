public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var groups = new Dictionary<string,IList<string>>();
        foreach(var str in strs){
            var sortedstr=string.Concat(str.OrderBy(c=>c));
            if(!groups.ContainsKey(sortedstr))
            {
                groups[sortedstr]=new List<string>();
            }
            groups[sortedstr].Add(str);
        }
        return groups.Values.ToList();
    }
}
