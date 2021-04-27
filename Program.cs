using System;
using System.Collections.Generic;

public class Solution
{
    public static string stringReverse(string s)  //string reverse function
    {
        string s1 = "";
        int num = s.Length - 1;

        while (num >= 0)
        {
            s1 = s1 + s[num];
            num--;
        }
        return s1;
    }

    public string LongestPalindrome(string s)
    {
        var list1 = new List<string>();
        var st = "";

        if (s.Length == 0 || s.Length == 1)
            return s;
        
        else if (s.Length == 2)
        {
            if (s == Solution.stringReverse(s))
                return s;
            else
            {
                var ch = Char.ToString(s[0]);
                return ch;
            }
        }
        
        else
        {
            for (int j = 0; j < s.Length; j++)
            {
                string empstr = "";
                empstr = empstr + s[j];
                for (int i = j + 1; i < s.Length; i++)
                {
                    empstr = empstr + s[i];
                    if (empstr == Solution.stringReverse(empstr))
                    {
                        list1.Add(empstr);
                    }
                }
            }
            if (list1.Count == 0)
            {
                var ch = Char.ToString(s[0]);
                return ch;
            }
            else
            { 
                var maxi = 0;
                foreach (var j in list1)
                {
                    if (maxi < j.Length)
                    {
                        maxi = j.Length;
                        st = j;
                    }
                }
            }
        }
        return st;

    }
}