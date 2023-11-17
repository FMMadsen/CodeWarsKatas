using KataSolution;

namespace TestProject
{
    [TestFixture]
    public class TestKata
    {
        [TestCase(new object[] { "needle" }, "found the needle at position 0")]
        [TestCase(new object[] { null, "needle" }, "found the needle at position 1")]
        [TestCase(new object[] { '3', "123124234", null, "needle", "world", "hay", 2, '3', true, false }, "found the needle at position 3")]
        [TestCase(new object[] { "283497238987234", "a dog", "a cat", "some random junk", "a piece of hay", "needle", "something somebody lost a while ago" }, "found the needle at position 5")]
        [TestCase(new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 8, 7, 5, 4, 3, 4, 5, 6, 67, 5, 5, 3, 3, 4, 2, 34, 234, 23, 4, 234, 324, 324, "needle", 1, 2, 3, 4, 5, 5, 6, 5, 4, 32, 3, 45, 54 }, "found the needle at position 30")]
        public void Test_Kyu_8_ANeddleInAHaystack(object[] input1, string expectedOutput)
        {
            // Arrange

            // Act
            var actual1 = Kata.FindNeedle1(input1);
            var actual2 = Kata.FindNeedle2(input1);

            // Assert
            Assert.That(actual1, Is.EqualTo(expectedOutput));
            Assert.That(actual2, Is.EqualTo(expectedOutput));
        }
    }
}