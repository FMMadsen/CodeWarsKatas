using KataSolution;

namespace TestProject
{
    [TestFixture]
    public class TestKata
    {
        [TestCase(true, true)]
        [TestCase(true, true, false, false)]
        [TestCase(true, false, true, false)]
        [TestCase(true, false, false, true)]
        [TestCase(false)]
        [TestCase(false, true, true)]
        [TestCase(false, false)]
        [TestCase(false, true, false, false, true)]
        [TestCase(false, false, false, false, false)]
        public void Test_Kyu_7_OnlyOne(bool expectedOutput, params bool[] input)
        {
            // Arrange
            
            // Act
            var actual = Kata.OnlyOne(input);

            // Assert
            Assert.That(actual, Is.EqualTo(expectedOutput));
        }
    }
}