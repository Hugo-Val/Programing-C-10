using AnswerExercise.Exercise;

namespace Test
{
    [TestClass]
    public class ExampleTest
    {
        [TestMethod]
        public void ReturnTrue_ReturnTrue()
        {
            // Arrange
            var example = new Example();

            // Act
            var result = example.ReturnTrue();

            // Assert
            Assert.AreEqual(true, result);
        }
    }
}