public class Solution {
    public string LargestOddNumber(string num) {
        for(int i=num.Length-1;i>=0;i--){
            if(Convert.ToInt16(num[i]) % 2 == 1){
                return num.Substring(0,i+1);
            }
        }
        return "";
    }
}
