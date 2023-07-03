class Solution {
    public String shortestCompletingWord(String licensePlate, String[] words){
        StringBuffer sb = new StringBuffer();
        for(int i=0;i<licensePlate.length();i++){
            if(Character.isAlphabetic(licensePlate.charAt(i))){
                sb.append(licensePlate.charAt(i));
            }
        }
        String lp = sb.toString().toLowerCase();
        int[] lpChars = new int[26];
        for(int i=0;i<lp.length();i++){
            lpChars[lp.charAt(i)-'a']++;
        }
        String targetStr = null;
        for(int i=0;i<words.length;i++){
            String currentStr = words[i].toLowerCase();
            if(!isCompletingWords(currentStr,lpChars)) continue;
            if(targetStr == null) targetStr= words[i];
            else{
                if(targetStr.length()>currentStr.length()){
                    targetStr=words[i];
                }
            }
        }
        return targetStr;
    }
    private boolean isCompletingWords(String str,int[] lpChars){
        int[] strChars=new int[26];
        for(int i=0;i<str.length();i++){
            strChars[str.charAt(i)-'a']++;
        }
        for(int i=0;i<26;i++){
            if(strChars[i]<lpChars[i]) return false;
        }
        return true;
    }
}
