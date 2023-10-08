using static Kyo_6___Multiples_of_3_or_5.Game.Logic2;

namespace Kyo_6___Multiples_of_3_or_5
{
    public static class Kata
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
