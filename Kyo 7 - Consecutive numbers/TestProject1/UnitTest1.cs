using ClassLibrary1;

namespace TestProject1
{
    public class Tests
    {
        [TestCase(new int[] {4,8,6}, 2)]
        [TestCase(new int[] {1,2,2,6,9}, 5)]
        [TestCase(new int[] {1,1,6,2,9}, 5)]
        [TestCase(new int[] {9,2,6,2,9,9,2}, 5)]
        [TestCase(new int[] {1,2,3}, 0)]
        [TestCase(new int[] {1}, 0)]
        [TestCase(new int[] {}, 0)]
        public void Test_Consecutive(int[] input, int expectedOutput)
        {
            // Arrange

            // Act
            var actual = Kata.Consecutive(input);

            // Assert
            Assert.That(actual, Is.EqualTo(expectedOutput));
        }
    }
}