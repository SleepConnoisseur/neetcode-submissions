public class Solution {
    public int Reverse(int x) {
        long reversed = 0;

        while (x != 0) {
            int digit = x % 10;
            x /= 10;
            reversed = reversed * 10 + digit;

            if (reversed > int.MaxValue || reversed < int.MinValue)
                return 0;
        }

        return (int)reversed;
    }
}
