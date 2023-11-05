namespace KataSolution
{
    public class Kata
    {
        public static int[] SquareOrSquareRoot(int[] array)
        {
            var newArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = SquareOrSquareRoot(array[i]);
            }

            return newArray;
        }

        public static int SquareOrSquareRoot(int number)
        {
            double squareRoot = System.Math.Sqrt(number);
            int squareRootIntegeer = (int)squareRoot;

            if (squareRoot == squareRootIntegeer)
                return squareRootIntegeer;
            else
                return number * number;
        }
    }
}
