public class Solution {
    public int IsWinner(int[] player1, int[] player2) {
        int score1 = CalculateScore(player1);
        int score2 = CalculateScore(player2);
        return score1 == score2 ? 0 : (score1 > score2 ? 1 : 2);
    }
    public int CalculateScore(int[] pins){
        int score = 0;
        for(int i=0;i<pins.Length;i++){
            if(i > 1 && (pins[i-1]==10 || pins[i-2]==10)){
                score += 2 * pins[i];
            }
            else if(i >0 && pins[i-1]==10){
                score += 2 * pins[i];
            }
            else{
                score += pins[i];
            }
        }
        return score;
    }
}
