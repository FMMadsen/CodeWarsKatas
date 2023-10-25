namespace KataSolution
{
    public static class Kata
    {
        /// <summary>
        /// 
        /// { -2, 1, -3, 4, -1, 2, 1, -5, 4 }   => 6
        /// { -2, -1, 0, 1, 2, 3, 4, 5 }        => 15
        /// { 2, 3, 4 }                         => 9
        /// { 2, 3, 4, -3, 2 }                  => 9
        /// { 0 }                               => 0
        /// 
        /// </summary>
        /// <param name="intArray">input aray if int</param>
        /// <returns>Largest sum of consequitive numbers</returns>
        public static int MaxSequence(int[] intArray)
        {
            int sumMax = 0;

            for (int i = 0; i < intArray.Length; i++)
            {
                int sum = DetermineLargestSumInSequence(intArray, i);
                sumMax = Max(sum, sumMax);
            }

            return sumMax;
        }

        public static int DetermineLargestSumInSequence(int[] intArray, int startIndex)
        {
            if (intArray.Length == 0)
                return 0;

            if (startIndex >= intArray.Length)
                return 0;

            if (intArray[startIndex] < 1)
                return 0;

            int sumMax = 0;
            int tmpSum = 0;

            for (int i = startIndex; i < intArray.Length; i++)
            {
                tmpSum += intArray[i];
                sumMax = Max(tmpSum, sumMax);
            }

            return sumMax;
        }

        private static int Max(int a, int b)
        {
            return a > b ? a : b;
        }
    }
}
