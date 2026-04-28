public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,List<string>> dict = new Dictionary<string,List<string>>();

        foreach(var x in strs){
            var key = new string(x.OrderBy(c => c).ToArray());
            if(dict.ContainsKey(key)){
                dict[key].Add(x);
            }
            else
            {
                dict.Add(key, new List<string>(){x});
            }
        }

        var result = new List<List<string>>();
        foreach(var x in dict){
            result.Add(x.Value);
        }
        return result;
    }
}
