public class Solution {
    public int[] FindEvenNumbers(int[] digits) {
        List<int> result = new List<int>();
        for(int i = 100;i<999;i+=2){
            int one_digit = i % 10;
            int two_digit = (i / 10) % 10;
            int three_digit = i / 100;
            bool one_digitF = false;
            bool two_digitF = false;
            bool three_digitF = false;
            for(int num=0;num<digits.Length;num++){
                if(!one_digitF && one_digit == digits[num]){
                    one_digitF = true;
                }
                else if(!two_digitF && two_digit == digits[num]){
                    two_digitF = true;
                }
                else if(!three_digitF && three_digit == digits[num]){
                    three_digitF = true;
                }
                if(one_digitF && two_digitF && three_digitF){
                    result.Add(i);
                    break;
                }
            }
        }
        return result.ToArray();
    }
}
