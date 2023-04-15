public class Solution {
    public int FirstUniqChar(string input) {
        // Create a dictionary to store the frequency of each character
    Dictionary<char, int> charFrequency = new Dictionary<char, int>();

    // Loop through the input string and count the frequency of each character
    for (int i = 0; i < input.Length; i++)
    {
        char c = input[i];
        if (charFrequency.ContainsKey(c))
        {
            charFrequency[c]++;
        }
        else
        {
            charFrequency.Add(c, 1);
        }
    }

    // Loop through the input string again and return the index of the first non-repeating character
    for (int i = 0; i < input.Length; i++)
    {
        char c = input[i];
        if (charFrequency[c] == 1)
        {
            return i;
        }
    }

    // If there are no non-repeating characters, return -1
    return -1;
    }
}