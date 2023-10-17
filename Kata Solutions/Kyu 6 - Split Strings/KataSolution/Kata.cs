using System;
using System.Collections.Generic;

namespace KataSolution
{
    public static class Kata
    {
        public static string[] SplitString(string input)
        {
            List<string> result = new List<string>();

            if (!string.IsNullOrEmpty(input))
            {
                if(input.Length % 2 == 1)
                {
                    input += "_";
                }

                int loops = input.Length / 2;
                
                for(int i = 0; i < loops; i++)
                {
                    result.Add(input.Substring(i * 2,2));
                }
            }

            return result.ToArray();
        }
    }
}
