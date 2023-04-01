public class Solution {
    public bool IsIsomorphic(string s, string t) {
        if(s.Length!=t.Length)
        {
            return false;
        }
        Dictionary<char,char> map = new Dictionary<char,char>();
        HashSet<char> usedChars=new HashSet<char>();
        for (int i=0; i<s.Length; i++)
        {
            char schar=s[i];
            char tchar=t[i];
            if (map.ContainsKey(schar))
            {
                if(map[schar]!=tchar)
                {
                    return false;
                }
            }
            else 
            {
                if(usedChars.Contains(tchar))
                {
                    return false;
                }
                map[schar]=tchar;
                usedChars.Add(tchar);
            }
        }
        return true;
    }
}