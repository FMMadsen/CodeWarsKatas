using KataSolution;

namespace TestProject
{
    [TestFixture]
    public class TestKata
    {
        [TestCase(10, 23)]
        [TestCase(20, 78)]
        [TestCase(200, 9168)]
        [TestCase(0, 0)]
        [TestCase(-5, 0)]
        public void Test_Kyu_6_MultipliesOf3r5(int input, int expectedOutput)
        {
            // Arrange
            Kata.Reset();

            // Act
            var actual = Kata.Solution(input);

            // Assert
            Assert.That(actual, Is.EqualTo(expectedOutput));
        }
    }
}