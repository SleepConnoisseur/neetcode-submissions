public class Solution {
    public bool IsPalindrome(string s) {
        if(string.IsNullOrEmpty(s))return true;
        if(s.Length == 1) return true;

        s = s.ToLower();

        int i = 0;
        int j = s.Length-1;
        while(i < j){
            if(!char.IsLetterOrDigit(s[i])){
                i++;
                continue;
            }
            if(!char.IsLetterOrDigit(s[j])){
                j--;
                continue;
            }
            if(s[i] != s[j]) return false;
            i++;
            j--;
        }
        return true;
    }
}
