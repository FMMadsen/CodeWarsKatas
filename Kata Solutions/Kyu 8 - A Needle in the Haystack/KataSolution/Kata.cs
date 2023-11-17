using System;

namespace KataSolution
{
    public class Kata
    {
        public static string FindNeedle1(object[] haystack)
        {
            for (int i = 0; i < haystack.Length; i++)
            {
                if (haystack[i] != null && haystack[i].ToString() == "needle")
                    return $"found the needle at position {i}";
            }
            return $"Not found";
        }

        public static string FindNeedle2(object[] haystack)
        {
            return $"found the needle at position {Array.IndexOf(haystack, "needle")}";
        }
    }
}
