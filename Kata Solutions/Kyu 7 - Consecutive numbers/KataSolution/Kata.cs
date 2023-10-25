namespace KataSolution
{
    using System.Linq;

    public static class Kata
    {
        public static int Consecutive(int[] intArrayInput)
        {
            if (intArrayInput.Length == 0)
                return 0;

            int lowest = intArrayInput.Min();
            int highest = intArrayInput.Max();
            int missingNumbersBetweenLowestAndHighest = 0;

            for (int i = lowest; i <= highest; i++)
            {
                if (!intArrayInput.Contains(i))
                    missingNumbersBetweenLowestAndHighest++;
            }

            return missingNumbersBetweenLowestAndHighest;
        }
    }
}
