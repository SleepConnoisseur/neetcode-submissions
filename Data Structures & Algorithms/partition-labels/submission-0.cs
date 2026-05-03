public class Solution
{
    public List<int> PartitionLabels(string s)
    {
        Dictionary<char, int[]> stash = new Dictionary<char, int[]>();

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (stash.ContainsKey(c))
            {
                stash[c][1] = i;
            }
            else
            {
                stash.Add(c, new int[] { i, i });
            }
        }

        var orderedList = stash.Values
                               .OrderBy(x => x[0])
                               .ToList();

        var result = new List<int[]>();

        foreach (var x in orderedList)
        {
            if (result.Count == 0)
            {
                result.Add(x);
            }
            else
            {
                var last = result[^1];

                if (last[1] >= x[0])
                {
                    last[1] = Math.Max(last[1], x[1]);
                }
                else
                {
                    result.Add(x);
                }
            }
        }

        return result.Select(r => r[1] - r[0] + 1).ToList();
    }
}