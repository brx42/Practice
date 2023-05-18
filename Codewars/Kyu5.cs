namespace Practice.Codewars;

public static class Kyu5
{
    #region Scramblies

    public static bool Scramble(string str1, string str2)
    {
        for (int i = 0; i < str2.Length; i++)
        {
            char valueStr2 = str2[i];

            int indexFirstStr = str1.IndexOf(valueStr2);

            if (indexFirstStr < 0)
            {
                return false;
            }

            char valueStr1 = str1[indexFirstStr];

            if (str2.Contains(valueStr1))
            {
                str1 = str1.Remove(indexFirstStr, 1);
            }
        }

        return true;
    }

    #endregion
}