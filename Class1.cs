using System;
using System.Collections.Generic;

public class Leetcode
{
    public int LengthOfLongestSubstring(string s)
    {
        var list1 = new List<string>();
        var maxi = 0;

        for (var i = 0; i < s.Length; i++)
        {
            var empstr = "";
            empstr = empstr + s[i];
            for (var j = i + 1; j < s.Length; j++)
            {
                if (empstr.Contains(s[j]))
                {
                    list1.Add(empstr);
                    break;
                }
                else
                {
                    empstr = empstr + s[j];
                }
            }
            list1.Add(empstr);
        }
        HashSet<string> set = new HashSet<string>(list1);
        foreach (var val in set)
        {
            if (maxi < val.Length)
            {
                maxi = val.Length;
            }
        }
        return maxi;
    }
}
