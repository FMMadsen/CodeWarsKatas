namespace KataSolution
{
    using System.Linq;

    public static class Kata
    {
        /// <summary>
        /// Given any number of boolean flags function should return true 
        /// if and only if one of them is true while others are false. 
        /// If function is called without arguments it should return false.
        /// 
        /// onlyOne() --> false
        /// onlyOne(true, false, false) --> true
        /// onlyOne(true, false, false, true) --> false
        /// onlyOne(false, false, false, false) --> false
        /// </summary>
        public static bool OnlyOne(params bool[] flags)
        {
            return flags.Count(i => i == true) == 1;
        }
    }
}
