public class Solution {
    public bool IsHappy(int n)        
    {
        HashSet<int> set = new HashSet<int>();
        while(set.Add(n)){
            if (n == 1) return true;
            else{
                var digits = n.ToString();
                int result = 0;
                foreach (char dig in digits)
                {
                    int x = 0;
                    if (int.TryParse(dig.ToString(), out x))
                    {
                        result += x*x;
                    }
                }
                n = result;
            }
        }
        return false;
   }
}
