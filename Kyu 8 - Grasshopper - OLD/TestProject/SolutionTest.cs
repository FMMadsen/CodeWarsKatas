using KataSolution;
using KataSolution.Game;

namespace TestProject
{
    [TestFixture]
    public class SolutionTest
    {
        [Test, Description("One Turn")]
        public void Test()
        {
            Kata.DoTurn();

            Assert.That(Logic.Log.Count, Is.EqualTo(6), "should call all 6 functions");
            Assert.That(Logic.Log[0], Is.EqualTo("RollDice"), "should roll dice first");
            Assert.That(Logic.Log[1], Is.EqualTo("Move"), "should move second");
            Assert.That(Logic.Log[2], Is.EqualTo("Combat"), "should combat third");
            Assert.That(Logic.Log[3], Is.EqualTo("GetCoins"), "should get coins fourth");
            Assert.That(Logic.Log[4], Is.EqualTo("BuyHealth"), "should buy health fifth");
            Assert.That(Logic.Log[5], Is.EqualTo("PrintStatus"), "should print status sixth");
        }
    }
}
