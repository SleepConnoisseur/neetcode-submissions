public class Solution {
    public bool IsAnagram(string s, string t) {
        var ss = s.ToCharArray().OrderBy(x=>x).ToList();
        var tt = t.ToCharArray().OrderBy(x=>x).ToList();

        if(ss.Count != tt.Count) return false;

        for(int i = 0; i < ss.Count ;i++){
            if(ss[i] != tt[i])return false;
        }
        return true;
    }
}
