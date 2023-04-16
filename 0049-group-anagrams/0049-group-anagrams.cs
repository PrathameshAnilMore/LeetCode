public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, IList<string>> dict = new  Dictionary<string, IList<string>>();
        
        foreach (string s in strs)
        {
            char[] charArray=s.ToCharArray();
            Array.Sort(charArray);
            string sortedstr = new string(charArray);
            
            if(!dict.ContainsKey(sortedstr))
            {
                dict[sortedstr]=new List<string>();
            }
            
            dict[sortedstr].Add(s);
        }
        
        return dict.Values.ToList();
    }
}