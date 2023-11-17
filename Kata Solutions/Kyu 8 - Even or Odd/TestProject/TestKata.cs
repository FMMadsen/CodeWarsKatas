using KataSolution;

namespace TestProject
{
    [TestFixture]
    public class TestKata
    {
        [TestCase(0, "Even")]
        [TestCase(1, "Odd")]
        [TestCase(2, "Even")]
        [TestCase(15, "Odd")]
        public void Test_Kyu_8_EvenOrOdd(int input1, string expectedOutput)
        {
            // Arrange

            // Act
            var actual = Kata.EvenOrOdd(input1);

            // Assert
            Assert.That(actual, Is.EqualTo(expectedOutput));
        }
    }
}