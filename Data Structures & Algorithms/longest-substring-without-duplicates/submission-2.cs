public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int max = s.Length == 0 ? 0 : 1;
        HashSet<char> checker = new HashSet<char>();

        if(s.Length > 1){
            for(int L = 0, R = 1 ; L < R && R < s.Length; ){
                checker.Clear();
                foreach(var x in s.Substring(L,R-L+1)){
                    if(!checker.Add(x)){
                        L += 1;
                        continue;
                    }
                } 
                max = Math.Max(max, R - L+1);
                R += 1;
            }
        }
        return max;
    }
}
