namespace TestProject
{
    public class TestKata
    {
        [TestCase(new int[] { 4, 3, 9, 7, 2, 1 }, new int[] { 2, 9, 3, 49, 4, 1 })]
        [TestCase(new int[] { 100, 101, 5, 5, 1, 1 }, new int[] { 10, 10201, 25, 25, 1, 1 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 1, 4, 9, 2, 25, 36 })]
        public void Test_Kyu_8_SquareOrNotToSquare(int[] input, int[] expectedOutput)
        {
            // Arrange

            // Act
            var actual = KataSolution.Kata.SquareOrSquareRoot(input);

            // Assert
            Assert.That(actual, Is.EqualTo(expectedOutput));
        }
    }
}