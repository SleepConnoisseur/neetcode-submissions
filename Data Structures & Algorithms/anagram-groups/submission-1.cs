public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        
        Dictionary<string, List<string>> dict = new Dictionary<string,List<string>>();

        foreach( var str in strs){
            string anag = new string(str.ToCharArray().OrderBy(x => x).ToArray());
            if(dict.ContainsKey(anag)){
                dict[anag].Add(str);
            }
            else{
                dict.Add(anag, new List<string>{str});
            }
        }

        return dict.Values.ToList();
    }
}
