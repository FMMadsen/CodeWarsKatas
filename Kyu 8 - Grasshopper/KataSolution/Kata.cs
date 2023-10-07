using KataSolution.Game;

namespace KataSolution
{
    public class Kata
    {
        public static void DoTurn()
        {
            Logic.RollDice();
            Logic.Move();
            Logic.Combat();
            Logic.GetCoins();
            Logic.BuyHealth();
            Logic.PrintStatus();
        }
    }
}
