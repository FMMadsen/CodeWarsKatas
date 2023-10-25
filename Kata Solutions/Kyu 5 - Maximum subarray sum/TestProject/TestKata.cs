using KataSolution;

namespace TestProject
{
    [TestFixture]
    public class TestKata
    {
        [TestCase(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6)]
        [TestCase(new int[] { -2, -1, 0, 1, 2, 3, 4, 5 }, 15)]
        [TestCase(new int[] { 2, 3, 4 }, 9)]
        [TestCase(new int[] { 2, 3, 4, -3, 2 }, 9)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { }, 0)]
        public void Test_Kyu_5_MaxSequence(int[] input, int expectedOutput)
        {
            // Arrange

            // Act
            var actual = Kata.MaxSequence(input);

            // Assert
            Assert.That(actual, Is.EqualTo(expectedOutput));
        }
    }
}