namespace KataSolution
{
    using System.Linq;

    public class Pattern16Tommy
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
            if (1 > n) { return ""; }

            char[] line = new char[n];
            string[] lines = new string[n];

            for (int i = 0; n > 0; n--, i++)
            {
                //line[i] = n.ToString()[^1];
                line[i] = n.ToString().Last();

                for (int iNext = i + 1; iNext < line.Length; iNext++)
                {
                    line[iNext] = line[i];
                }

                lines[i] = new string(line);
            }

            // consider replacing '\n' with Environment.NewLine
            return string.Join("\n", lines);
        }
    }
}
