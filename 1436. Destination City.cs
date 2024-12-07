public class Solution {
    public string DestCity(IList<IList<string>> paths) {
        HashSet<string> city = new HashSet<string>();
        Dictionary<string,string> map = new Dictionary<string,string>();
        foreach(var path in paths){
            string fromCity = path[0];
            string toCity = path[1];
            city.Add(fromCity);
            city.Add(toCity);
            map[fromCity] = toCity;
        }
        foreach(var cityy in city){
            if(!map.ContainsKey(cityy)){
                return cityy;
            }
        }
        return "";
        
    }
}
