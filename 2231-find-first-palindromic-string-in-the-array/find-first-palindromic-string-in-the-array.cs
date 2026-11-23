public class Solution {
    public string FirstPalindrome(string[] words) {
        foreach(string w in words){
            int i = 0, j = w.Length-1;
            while(i<j){
                if(w[i]!= w[j]){

                    break;
                }
                i++;
                j--;
            }
            if(i>=j)
                return w;
        }
        return "";
    }
}