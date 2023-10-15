using System.Text;

namespace Practice.LeetCode;

public static class Medium
{
    #region 3

    public static int LengthOfLongestSubstring(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return default;
        }

        int countSubstr = 1;
        int currentCountSubstr = 0;
        StringBuilder substring = new();

        for (int i = 0; i < s.Length; i++)
        {
            char currentLetterI = s[i];
            substring.Append(currentLetterI);
            currentCountSubstr++;
    
            for (int j = i + 1; j < s.Length; j++)
            {
                char currentLetterJ = s[j];

                if (substring.ToString().Contains(currentLetterJ))
                {
                    substring.Remove(0, currentCountSubstr);
                    currentCountSubstr = 0;

                    break;
                }

                currentCountSubstr++;
                substring.Append(currentLetterJ);

                if (currentCountSubstr > countSubstr)
                {
                    countSubstr = currentCountSubstr;
                }
            }
        }
        
        GC.Collect();

        return countSubstr;
    }

    #endregion
}