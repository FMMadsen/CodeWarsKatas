using System.Collections.Generic;

namespace ConsoleApp1
{
    public static class Kata
    {
        private static HashSet<int> multiplies = new HashSet<int>();

        public static int Solution(int value)
        {
            Reset();

            for (int c = 1; c < value; c++)
            {
                if (c % 3 == 0)
                {
                    AddMultiplier(c);
                }

                if (c % 5 == 0)
                {
                    AddMultiplier(c);
                }
            }

            return SummarizeAllMultipliers();
        }

        public static void Reset()
        {
            multiplies.Clear();
        }

        private static void AddMultiplier(int multiplier)
        {
            if (!multiplies.Contains(multiplier))
            {
                multiplies.Add(multiplier);
            }
        }

        private static int SummarizeAllMultipliers()
        {
            int sum = 0;
            foreach(int multiplier in multiplies)
            {
                sum += multiplier;
            }

            return sum;
        }
    }
}
