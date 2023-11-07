namespace KataSolution
{
    using System.Text;

    public class Pattern16
    {
        /***********************************************************************
        -35 => ""
        -1  => ""
        0   => ""
        1   => "1"
        2   => "22\n21"
        3   => "333\n322\n321"
        7   => "7777777\n7666666\n7655555\n7654444\n7654333\n7654322\n7654321"
        17  => "77777777777777777\n76666666666666666\n76555555555555555\n76544444444444444\n76543333333333333\n76543222222222222\n76543211111111111\n76543210000000000\n76543210999999999\n76543210988888888\n76543210987777777\n76543210987666666\n76543210987655555\n76543210987654444\n76543210987654333\n76543210987654322\n76543210987654321"
        ************************************************************************/
        public static string Pattern(int n)
        {
            char newline = '\n';
            StringBuilder sb = new StringBuilder();

            int currentNumberSequenceCountDownCount = 0;  // starting 0 and counting up
            int baseNumber = GetOnesFromNumber(n);

            for (int s = 0; s < n; s++)
            {
                int currentDigit = baseNumber;
                for (int d = 0; d < n; d++)
                {
                    sb.Append(currentDigit);

                    if (d < s)
                        currentDigit = currentDigit == 0 ? 9 : currentDigit - 1;
                }

                currentNumberSequenceCountDownCount++;

                if (s < n - 1)
                    sb.Append(newline);
            }

            return sb.ToString();
        }

        public static int GetOnesFromNumber(int number)
        {
            return number % 10;
        }

    }
}
