using System.Collections.Generic;

namespace Kyo_6___Multiples_of_3_or_5.Game
{
    public static class Logic2
    {
        public static List<string> Log = new List<string>();

        public static void Combat()
        {
            LogEvent("Combat");
        }

        public static void BuyHealth()
        {
            LogEvent("BuyHealth");
        }

        public static void GetCoins()
        {
            LogEvent("GetCoins");
        }

        public static void PrintStatus()
        {
            LogEvent("PrintStatus");
        }

        public static void RollDice()
        {
            LogEvent("RollDice");
        }

        public static void Move()
        {
            LogEvent("Move");
        }

        private static void LogEvent(string message)
        {
            Log.Add(message);
        }
    }
}
