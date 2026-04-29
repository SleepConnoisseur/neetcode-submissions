public class Solution {
    public bool IsValid(string s) {
        Stack<char> stash = new Stack<char>();

        foreach(char c in s){
            if(c == '(') stash.Push(c);
            else if(c == '{') stash.Push(c);
            else if(c == '[') stash.Push(c);
            else if(c == ')'){
                if(stash.Count > 0 && stash.Peek() == '(') stash.Pop();
                else return false;
            } 
            else if(c == '}'){
                if(stash.Count > 0 && stash.Peek() == '{') stash.Pop();
                else return false;
            } 
            else if(c == ']'){
                if(stash.Count > 0 && stash.Peek() == '[') stash.Pop();
                else return false;
            } 
        }

        return stash.Count == 0;
    }
}
