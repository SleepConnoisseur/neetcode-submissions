public class Solution {
    List<List<int>> result = new List<List<int>>();
    public List<List<int>> Permute(int[] nums) {
        List<int> cache = new List<int>();
        BFS(nums, cache);
        return result;
    }

    public void BFS(int[] nums, List<int> cache){
        if(cache.Count() == nums.Count()){
            result.Add(cache);
        }
        foreach(var x in nums.Except(cache)){
            List<int> cacheCopy = new List<int>(cache);
            cacheCopy.Add(x);
            BFS(nums, cacheCopy);
        }
    }
}
