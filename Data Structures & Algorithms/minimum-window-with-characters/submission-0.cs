public class Solution {
    public string MinWindow(string s, string t){

    Dictionary<char, int> tMap = new Dictionary<char, int>();
    foreach (char x in t)
    {
        if (tMap.ContainsKey(x))
        {
            tMap[x] += 1;
        }
        else
        {
            tMap.Add(x, 1);
        }
    }

    Dictionary<char, int> sMap = new Dictionary<char, int>();
    List<string> resultList = new List<string>();

    for (int i = 0; i < s.Length;)
    {
        if (!t.Contains(s[i]))
        {
            i++;
            continue;
        }
        for (int j = i; j < s.Length; j++)
        {
            if (t.Contains(s[j]))
            {
                if (sMap.ContainsKey(s[j])) { 
                
                    if(sMap[s[j]] < tMap[s[j]])
                    {
                        sMap[s[j]] += 1;
                    }
                }
                else
                {
                    sMap.Add(s[j], 1);
                }

                if ((j - i) >= t.Length - 1)
                {
                    if (AreDictionariesEquivalent(sMap, tMap))
                    {
                        resultList.Add(s.Substring(i, (j - i) + 1));
                        sMap.Clear();
                        break;
                    }
                }
            }

        }
        i++;
    }

    return resultList.OrderBy(x => x.Length).FirstOrDefault();
    }
    bool AreDictionariesEquivalent(Dictionary<char, int> dict1, Dictionary<char, int> dict2)
    {
        // First check if they have the same number of elements
        if (dict1.Count != dict2.Count)
            return false;

        // Check if all keys and values are the same in both dictionaries
        return dict1.All(pair => dict2.TryGetValue(pair.Key, out var value) && value == pair.Value);
    }
}
