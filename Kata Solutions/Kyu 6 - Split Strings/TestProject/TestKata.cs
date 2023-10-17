namespace TestProject
{
    [TestFixture]
    public class TestKata
    {
        [TestCase("", new string[] { })]
        [TestCase("a", new string[] { "a_" })]
        [TestCase("abc", new string[] { "ab", "c_" })]
        [TestCase("abcdef", new string[] { "ab", "cd", "ef" })]
        public void Test_Kyu_6_SplitStrings(string input, string[] expectedOutput)
        {
            // Arrange

            // Act
            var actual = KataSolution.Kata.SplitString(input);

            // Assert
            Assert.That(actual, Is.EqualTo(expectedOutput));
        }
    }
}