public class Solution {
    public List<List<int>> CombinationSum2(int[] candidates, int target) {
        
        if(candidates.Length == 0) return new List<List<int>>();
        var ordered = candidates.OrderBy(x=>x).ToArray();
        if(ordered[0] > target) return new List<List<int>>();

        var combSet = new HashSet<string>();
        var result = new List<List<int>>();

        backtracking(ordered,0,new List<int>());
        return result;

        void backtracking(int[] ordered, int index, List<int> currentComb){
            for(int i  = index ; i < ordered.Length ; i++){
                var copy = new List<int>(currentComb);
                copy.Add(ordered[i]);
                if(copy.Sum() == target){
                    if(combSet.Add(string.Join("", copy))){
                        result.Add(copy);
                        return;
                    }
                }
                if(copy.Sum() > target) return;
                backtracking(ordered, i+1, copy);
            }
        }

    }
}
