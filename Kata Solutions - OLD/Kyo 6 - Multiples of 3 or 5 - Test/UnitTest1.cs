using Kyo_6___Multiples_of_3_or_5;
using Kyo_6___Multiples_of_3_or_5.Game;

namespace Kyo_6___Multiples_of_3_or_5___Test
{

    public class Tests
    {
        [Test, Description("One Turn")]
        public void Test()
        {
            Kata.DoTurn();

            Assert.That(Logic2.Log.Count, Is.EqualTo(6), "should call all 6 functions");
            Assert.That(Logic2.Log[0], Is.EqualTo("RollDice"), "should roll dice first");
            Assert.That(Logic2.Log[1], Is.EqualTo("Move"), "should move second");
            Assert.That(Logic2.Log[2], Is.EqualTo("Combat"), "should combat third");
            Assert.That(Logic2.Log[3], Is.EqualTo("GetCoins"), "should get coins fourth");
            Assert.That(Logic2.Log[4], Is.EqualTo("BuyHealth"), "should buy health fifth");
            Assert.That(Logic2.Log[5], Is.EqualTo("PrintStatus"), "should print status sixth");
        }
    }
}