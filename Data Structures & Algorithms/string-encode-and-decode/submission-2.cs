public class Solution {

    public string Encode(IList<string> strs) {
        var result = "";
        foreach(var x in strs){
            result = result + x.Length + "#" + x;
        }
        return result;
    }

    public List<string> Decode(string s) {
        var result = new List<string>();
        while(s.Length > 0){
            for(int i = 0; i < s.Length ; i++){
                if(s[i] == '#'){
                    int count = int.Parse(s.Substring(0,i));
                    var substring = s.Substring(i+1, count);
                    result.Add(substring);
                    s = s.Substring(i+count+1);
                    break;
                }
            }
        }
        return result;
    }
}