using static KataSolution.Game.Logic;

namespace KataSolution
{
    public class Kata
    {
        public static void DoTurn()
        {
            RollDice();
            Move();
            Combat();
            GetCoins();
            BuyHealth();
            PrintStatus();
        }
    }
}
