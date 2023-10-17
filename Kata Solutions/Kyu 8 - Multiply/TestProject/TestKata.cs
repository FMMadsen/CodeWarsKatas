using KataSolution;

namespace TestProject
{
    [TestFixture]
    public class TestKata
    {
        [TestCase(1, 1, 1)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 3, 3)]
        [TestCase(8, 10, 80)]
        public void Test_Kyu_8_Multiply(int input1, int input2, int expectedOutput)
        {
            // Arrange

            // Act
            var actual = CustomMath.multiply(input1, input2);

            // Assert
            Assert.That(actual, Is.EqualTo(expectedOutput));
        }
    }
}