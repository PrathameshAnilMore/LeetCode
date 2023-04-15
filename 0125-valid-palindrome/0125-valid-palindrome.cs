public class Solution {
    public bool IsPalindrome(string s) {
        
      
        
        
        s= new string(s.Where(char.IsLetterOrDigit).Select(char.ToLower).ToArray());
        
        for (int i=0,j=s.Length-1; i<j; i++,j--)
        {
            if (s[i]!=s[j])
            {
                return false;
            }
        }
        
        return true;
        
        
        
    }
}