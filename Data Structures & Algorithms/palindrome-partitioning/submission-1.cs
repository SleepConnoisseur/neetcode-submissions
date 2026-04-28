public class Solution {
    public List<List<string>> Partition(string s) {
        
        var result = new List<List<string>>();
        var current = new List<string>();

        DFS();
        
        return result;

        void DFS(int index = 0){
            for(int i = 1; i <= s.Length - index ; i++){
                var left = s.Substring(index, i);
                bool isPal = true;

                for(int l = 0, r = left.Length-1 ; l <= r; l++,r--){
                    if(left[l] != left[r]){
                        isPal = false;
                    }
                }
                if(isPal){
                    current.Add(left);
                    if(index + i == s.Length){
                        result.Add(new List<string>(current));
                    }
                    else{
                        DFS(index + i);
                    }
                    if(current.Count > 0){
                    current.RemoveAt(current.Count -1);
                    }
                }   
            }
        }
    }
}
