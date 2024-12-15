public class Solution {
    public bool HaveConflict(string[] event1, string[] event2) {
        /*int check1 = event2[0].CompareTo(event1[0]);
        int check2 = event2[0].CompareTo(event1[1]);
        int check3 = event1[0].CompareTo(event2[0]);
        int check4 = event1[0].CompareTo(event2[1]);
        if((check1 >= 0 && check2 <= 0) || (check3 >= 0 && check4 <= 0)){
            return true;
        }
        else{
            return false;
        }*/
        return !(event1[1].CompareTo(event2[0]) < 0 || event2[1].CompareTo(event1[0]) < 0);
    }
}
