public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) {
            return false;
        }
        var ss = new Dictionary<char,int>();
        foreach(char x in s){
            if(ss.ContainsKey(x)) ss[x] += 1;
            else ss.Add(x,1);
        }
        foreach(char x in t){
            if(ss.ContainsKey(x)) ss[x] -= 1;
            else ss.Add(x,1);
        }

        foreach(var x in ss){
            if(x.Value != 0) return false;
        }
        return true;
    }
}
