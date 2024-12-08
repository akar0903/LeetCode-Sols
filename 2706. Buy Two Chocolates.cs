public class Solution {
    public int BuyChoco(int[] prices, int money) {
        int result = 0;
        int min = int.MaxValue;
        int secondmin = int.MaxValue;
        for(int i=0;i<prices.Length;i++){
            if (prices[i] < min) {
                secondmin = min; 
                min = prices[i]; 
            } else if (prices[i] < secondmin) {
                secondmin = prices[i]; 
            }
        }
        if(min + secondmin <= money){
            result = money - (min + secondmin);
        }
        else{
            result =money;
        }
        return result;
    }
}
