namespace TestProject
{
    public class TestKata
    {
        [TestCase("", true)]
        [TestCase("()", true)]
        [TestCase("(){}[]", true)]
        [TestCase("([{}])", true)]
        [TestCase("(}", false)]
        [TestCase("[(])", false)]
        [TestCase("[({})](]", false)]
        [TestCase("})]", false)]
        [TestCase("(((({{", false)]
        public void Test_Kyu_6_ValidBraces(string input, bool expectedOutput)
        {
            // Arrange

            // Act
            var actual = KataSolution.Brace.validBraces(input);

            // Assert
            Assert.That(actual, Is.EqualTo(expectedOutput));
        }
    }
}