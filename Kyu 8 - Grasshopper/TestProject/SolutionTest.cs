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

            Assert.AreEqual(6, Logic.Log.Count, "should call all 6 functions");
            Assert.AreEqual("RollDice", Logic.Log[0], "should roll dice first");
            Assert.AreEqual("Move", Logic.Log[1], "should move second");
            Assert.AreEqual("Combat", Logic.Log[2], "should combat third");
            Assert.AreEqual("GetCoins", Logic.Log[3], "should get coins fourth");
            Assert.AreEqual("BuyHealth", Logic.Log[4], "should buy health fifth");
            Assert.AreEqual("PrintStatus", Logic.Log[5], "should print status sixth");
        }
    }
}
